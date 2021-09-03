using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Request;
using Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using Utility;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GlobalVars.SiteUrl = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host.Value + "/";

            try
            {
                if (HttpContext.Request.Cookies[GlobalVars.cookieUserNameKey] != null && HttpContext.Request.Cookies[GlobalVars.cookiePasswordKey] != null)
                {
                    GlobalVars.cookiePassword = stringHasher.Decrypt(HttpContext.Request.Cookies[GlobalVars.cookiePasswordKey], Constants.Privatekey);
                    GlobalVars.cookieUserName = stringHasher.Decrypt(HttpContext.Request.Cookies[GlobalVars.cookieUserNameKey], Constants.Privatekey);
                }
                else
                {
                    GlobalVars.cookiePassword = "";
                    GlobalVars.cookieUserName = "";
                }
            }
            catch { }
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin([FromBody] LoginRequest obj)
        {
            obj.deviceinfo = "temp";
            obj.URL = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host.Value + "/";
            LoginResponse LstResponse = new LoginResponse();
            string Url = GlobalVars.APIUrl + "api/Login/UserLogin";

            LoginRequest objParam = new LoginRequest { UserName = obj.UserName, Password = obj.Password, deviceinfo = obj.deviceinfo, URL = obj.URL };
            var response = IM_InvokePostMethod(objParam, Url);

            dynamic strResAPI = response.ToString();
            LstResponse = JsonConvert.DeserializeObject<LoginResponse>(strResAPI);
            if (LstResponse.success)
            {
                HttpContext.Session.SetString(Enums.Session.UserName.ToString(), LstResponse.result.userName);
                HttpContext.Session.SetString(Enums.Session.UserPassword.ToString(), stringHasher.Encrypt(obj.Password, Constants.Privatekey));
                HttpContext.Session.SetString(Enums.Session.UserAccessToken.ToString(), LstResponse.result.access_token);
                HttpContext.Session.SetString(Enums.Session.UserID.ToString(), LstResponse.result.userId.ToString());
                GlobalVars.LoginInfoId = LstResponse.result.LoginInfoId.ToString();

                if (obj.IsRemember)
                {
                    Microsoft.AspNetCore.Http.CookieOptions option = new Microsoft.AspNetCore.Http.CookieOptions();
                    option.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Append(GlobalVars.cookieUserNameKey, stringHasher.Encrypt(obj.UserName, Constants.Privatekey), option);
                    Response.Cookies.Append(GlobalVars.cookiePasswordKey, stringHasher.Encrypt(obj.Password, Constants.Privatekey), option);
                }
                else
                {
                    Response.Cookies.Delete(GlobalVars.cookieUserNameKey);
                    Response.Cookies.Delete(GlobalVars.cookiePasswordKey);
                    GlobalVars.cookieUserName = "";
                    GlobalVars.cookiePassword = "";
                }
            }
            return Json(LstResponse);
        }
        [HttpPost]
        public IActionResult UserRegister([FromBody] RegisterRequest obj)
        {
            ServiceResponse LstResponse = new ServiceResponse();
            if (obj.Password != obj.ConfirmPassword)
            {
                LstResponse.success = false;
                LstResponse.message = "Confirm password not match.";
            }
            else
            {
                obj.URL = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host.Value + "/";
                string Url = GlobalVars.APIUrl + "api/Login/UserRegister";
                var response = IM_InvokePostMethod(obj, Url);
                dynamic strResAPI = response.ToString();
                LstResponse = JsonConvert.DeserializeObject<ServiceResponse>(strResAPI);
            }
            return Json(LstResponse);
        }
        [HttpPost]
        public IActionResult ForgotPassword([FromBody] RegisterRequest obj)
        {
            ServiceResponse LstResponse = new ServiceResponse();
            string Url = GlobalVars.APIUrl + "api/Login/ForgotPassword?Email="+obj.Email;
            var response = IM_InvokePostMethod("", Url);
            dynamic strResAPI = response.ToString();
            LstResponse = JsonConvert.DeserializeObject<ServiceResponse>(strResAPI);
            return Json(LstResponse);
        }

        public string IM_InvokePostMethod(object objParam, string url)
        {
            string strResponse = "";
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PostAsJsonAsync(url, objParam).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = response.Content.ReadAsStringAsync();
                        if (responseString.IsCompleted)
                        {
                            strResponse = responseString.Result;
                        }
                    }
                }
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            strResponse = reader.ReadToEnd();
                        }
                    }
                }
            }
            return strResponse;
        }
    }
}


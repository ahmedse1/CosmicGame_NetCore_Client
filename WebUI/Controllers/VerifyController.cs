using Microsoft.AspNetCore.Mvc;
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
    public class VerifyController : Controller
    {
        public IActionResult Index(string t)
        {
            string strToken = System.Net.WebUtility.UrlDecode(t);
            string strId = Utility.PasswordHasher.Decrypt(strToken, Utility.Constants.Privatekey);
            string[] arr = strId.Split(';');
            if (Convert.ToDateTime(arr[1].ToString()).AddDays(1) > Convert.ToDateTime(Utility.clsCommon.GetDateTime()))
            {
                ServiceResponse LstResponse = new ServiceResponse();
                string strUserid = arr[0];
                string Url = GlobalVars.APIUrl + "api/Login/Userverify?userId=" + strUserid;
                var response = IM_InvokePostMethod("", Url);
                dynamic strResAPI = response.ToString();
                LstResponse = JsonConvert.DeserializeObject<ServiceResponse>(strResAPI);
                if (LstResponse.success)
                {
                    ViewBag.message = "Email Verification success.!";
                }
                else
                {
                    ViewBag.message = "Verification failed due to invalid or expired link!";
                }
            }
            else
            {
                ViewBag.message = "Verification link is invalid or expired!";
            }
            return View();
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

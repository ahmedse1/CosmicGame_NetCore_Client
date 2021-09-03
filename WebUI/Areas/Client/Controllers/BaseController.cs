using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using Utility;
using static Utility.GlobalVars;

namespace WebUI.Areas.Client.Controllers
{
    //[EnableCors("CorsPolicy")]
    public class BaseController : Controller
    {
        public void userLogOut()
        {
            HttpContext.Session.Clear();
        }
        public string IM_InvokePostMethod(object objParam, string url)
        {
            string strResponse = "";
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization
                        = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString(Enums.Session.UserAccessToken.ToString()));
                    var response = client.PostAsJsonAsync(GlobalVars.APIUrl + url, objParam).Result;
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

        public async Task<string> IM_InvokeGetMethod(string url)
        {
            string strResponse = "";
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization
                        = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString(Enums.Session.UserAccessToken.ToString()));
                    var response = await client.GetAsync(GlobalVars.APIUrl + url);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = response.Content.ReadAsStringAsync();
                        if (responseString.IsCompleted)
                        {
                            strResponse = await responseString;
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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace WebUI.Areas.Client.Controllers
{
    [Area("Client")]
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            GlobalVars.SiteUrl = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host.Value + "/";
            return View();
        }
        [HttpPost]
        public IActionResult Logout()
        {
            userLogOut();
            return Json("");
        }
        [HttpPost]
        public IActionResult validateSession()
        {
            if (HttpContext.Session.GetString(Enums.Session.UserAccessToken.ToString()) == null || HttpContext.Session.GetString(Enums.Session.UserAccessToken.ToString()) == "")
            {
                userLogOut();
                return Json(false);
            }
            else
            {
                return Json(true);
            }
        }
    }
}

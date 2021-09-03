using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Request;
using Models.Response;
using System;
using Utility;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;
using Zebble.Services;
using Newtonsoft.Json;

namespace WebUI.Areas.Client.Controllers
{
    [Area("Client")]
    public class ChartHolderController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ChartHolderDetail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveChartHolder([FromBody] ChartHolderRequest obj)
        {
            var response = IM_InvokePostMethod(obj, "Client/ChartHolder/SaveChartHolder");
            return Json(response);
        }

        [HttpPost]
        public IActionResult getChartHolderList()
        {
            var response = IM_InvokePostMethod("", "Client/ChartHolder/ChartHolderList"); // it is used to call API
            return Json(response);
        }

        [HttpPost]
        public IActionResult getSingleChartHolder(int IDs)
        {
            var response = IM_InvokePostMethod(Convert.ToInt32(IDs.ToString()), "Client/ChartHolder/SingleChartHolder");
            return Json(response);
        }

        [HttpPost]
        public IActionResult deleteChartHolderRecord(string IDs)
        {
            var response = IM_InvokePostMethod(Convert.ToInt32(IDs), "Client/ChartHolder/removeChartHolderRecord");
            return Json(response);
        }
        [HttpPost]
        public IActionResult getCountries()
        {
            var response = IM_InvokePostMethod("", "Client/ChartHolder/Countries");
            return Json(response);
        }


        [HttpPost]
        public IActionResult getTimeZone(string strCountryName)
        {
            var response = IM_InvokePostMethod(strCountryName, "Client/ChartHolder/TimeZone");
            return Json(response);
        }
        [HttpPost]
        public JsonResult OnGetDMSLocations(decimal? latitude, decimal? longitude)
        {
            if (latitude == null)
            {
                latitude = 0;
            }
            if (longitude == null)
            {
                longitude = 0;
            }

            //  Look for Alternative  Function that converts Deg. Digit to DMS 

            GeoLocationService locationServic = new GeoLocationService();
            DmsLocation dmsLocation = locationServic.GetDmsLocation(latitude.Value, longitude.Value);
            if (dmsLocation != null)
            {
                string DMSLat = dmsLocation.Latitude.ToString();
                string DMSLong = dmsLocation.Longitude.ToString();
                var response = new JsonResult(new
                {
                    success = true,
                    DMSLat = DMSLat,
                    DMSLong = DMSLong,
                    LatLocator = DMSLat.Substring(DMSLat.Length - 1, 1),
                    LngLocator = DMSLong.Substring(DMSLong.Length - 1, 1)
                });
                var result = JsonConvert.SerializeObject(response.Value);
                return Json(result);

            }
            return new JsonResult(new { success = false });
        }


        [HttpPost]
        public IActionResult getCurrentAddressList(int IDs)
        {
            var response = IM_InvokePostMethod(IDs, "Client/ChartHolder/CurrentAddressList");
            return Json(response);
        }

        [HttpPost]
        public IActionResult AddEditCurrentAddress([FromBody] CurrentAddressRequest obj)
        {
            if (obj.wrChartHolderId != null)
            {
                var response = IM_InvokePostMethod(obj, "Client/ChartHolder/AddEditCurrentAddress");
                return Json(response);
            }
            else
            {
                ServiceResponse objResponse = new ServiceResponse();
                objResponse.success = false;
                objResponse.message = "Please save Chartholder's Detail First.!";
                return Json(objResponse);
            }
        }

        [HttpPost]
        public IActionResult getSingleCurrentAddress(int IDs)
        {
            var response = IM_InvokePostMethod(Convert.ToInt32(IDs.ToString()), "Client/ChartHolder/getSingleCurrentAddress");
            return Json(response);
        }
        [HttpPost]
        public IActionResult _loadChartView()
        {
            return PartialView("~/Areas/Client/Views/ChartHolder/_ChartView.cshtml");
        }

    }
}

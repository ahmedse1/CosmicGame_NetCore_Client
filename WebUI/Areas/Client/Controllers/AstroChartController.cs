using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Request;
using Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tapin.Model.CustomTools;
using Utility;
using WebUI.Models;

namespace WebUI.Areas.Client.Controllers
{
    [Area("Client")]
    public class AstroChartController : BaseController
    {
        public Array arr_Bhawa;
        private int IFlag = 0;
        private int sidmode = 0;
        public double ayanamshaCalculated = 0, tempAyanamshaCalculated = 0;
        public double Ayanamsha_lahiri = 0, Ayanamsha_raman = 0, Ayanamsha_krishnamurti = 0, Ayanamsha_NewCombe = 0, Ayanamsha_999 = 0;
        public double ayan_lahiri = 0, ayan_raman = 0, ayan_krishnamurti = 0, ayan_NewCombe = 0, ayan_999 = 0;
        public string ayan_lahiriDMS = "", ayan_ramanDMS = "", ayan_krishnamurtiDMS = "", ayan_NewCombeDMS = "", ayan_999DMS = "";
        public List<Bhava> BhawaPlanet_BList = new List<Bhava>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult getAstroChart(int IDs)
        {
            var response = IM_InvokePostMethod(Convert.ToInt32(IDs.ToString()), "Client/ChartHolder/getAstroChart");
            return Json(response);
        }

        [HttpPost]
        public IActionResult getVimsoChart(int IDs)
        {
            string strResponse = "";
            var response = IM_InvokePostMethod(Convert.ToInt32(IDs), "Client/ChartHolder/getVimsoChart");
            var vResponse = JsonConvert.DeserializeObject<ServiceResponse>(response);
            if (vResponse != null && vResponse.result != null)
            {
                var vList = JsonConvert.DeserializeObject<List<tblVimsoChartResponse>>(vResponse.result.ToString());
                if (vList != null)
                {
                    var selectedList = vList.Select<tblVimsoChartResponse, tblVimsoChartResponse>(x => new tblVimsoChartResponse
                    {
                        Index = x.Index,
                        Vimso_pd = x.Vimso_pd,
                        StarLord = x.StarLord,
                        Di_Gp = x.Di_Gp,
                        Pu_Gp = x.Pu_Gp,
                        An_Gp = x.An_Gp,
                        So_Gp = x.So_Gp,
                        S1SL = x.S1SL,
                        S2SL = x.S2SL,
                        S3SL = x.S3SL,
                        S4SL = x.S4SL,
                        GroupName = x.StarLord,
                        GroupId = x.Di_Gp,
                        S4SL_ArcDist = x.S4SL_ArcDist,
                        vimsoMoved = x.vimsoMoved,
                        timeDifference = x.timeDifference,
                        newDate = x.newDate,
                        strNewDate = x.strNewDate,
                        DOB = x.DOB,
                        isLast = x.isLast,
                    }).ToList();
                    HttpContext.Session.SetString(Enums.SessionVimsoChart.Data.ToString(), JsonConvert.SerializeObject(selectedList).ToString());
                    strResponse = getVimsoData(selectedList, true);
                }
            }
            return Json(strResponse);
        }

        [HttpGet]
        public async Task<IActionResult> getVimsoChart_DI_Grp(int id)
        {
            string strResponse = "";
            var response = await IM_InvokeGetMethod($"Client/ChartHolder/getVimsoChart_DI_Grp?strChartHolderID={id}");
            var vResponse = JsonConvert.DeserializeObject<ServiceResponse>(response);
            if (vResponse?.result != null)
            {
                var vList = JsonConvert.DeserializeObject<List<tblVimsoChartResponse>>(vResponse.result.ToString());
                if (vList != null)
                {
                    var selectedList = vList.Select<tblVimsoChartResponse, tblVimsoChartResponse>(x => new tblVimsoChartResponse
                    {
                        Index = x.Index,
                        Vimso_pd = x.Vimso_pd,
                        StarLord = x.StarLord,
                        Di_Gp = x.Di_Gp,
                        Pu_Gp = x.Pu_Gp,
                        An_Gp = x.An_Gp,
                        So_Gp = x.So_Gp,
                        S1SL = x.S1SL,
                        S2SL = x.S2SL,
                        S3SL = x.S3SL,
                        S4SL = x.S4SL,
                        GroupName = x.StarLord,
                        GroupId = x.Di_Gp,
                        S4SL_ArcDist = x.S4SL_ArcDist,
                        vimsoMoved = x.vimsoMoved,
                        timeDifference = x.timeDifference,
                        newDate = x.newDate,
                        strNewDate = x.DOB.ToString("MM/dd/yyyy hh:mm:ss"),
                        DOB = x.DOB,
                        isLast = x.isLast,
                    }).ToList();
                    //HttpContext.Session.SetString(Enums.SessionVimsoChart.Data.ToString(), JsonConvert.SerializeObject(selectedList));
                    //strResponse = getVimsoData(selectedList, true);

                    return Json(JsonConvert.SerializeObject(selectedList));
                }
            }
            return Json(strResponse);
        }

        public string getVimsoData(List<tblVimsoChartResponse> Data, bool isDissai = false)
        {
            if (Data.Count > 0)
            {
                List<tblVimsoChartResponse> objCalculatedList = new List<tblVimsoChartResponse>();

                Decimal Opening = 0;
                Decimal Closing = 0;
                Decimal VimsoMoved = 0;
                Decimal timeDifference = 0;
                DateTime currentDate = Data[0].DOB;
                if (Data.Count > 0)
                {
                    for (int i = 0; i < Data.Count; i++)
                    {
                        if (i == 0)
                        {
                            Opening = Convert.ToDecimal(Data[i].S4SL_ArcDist.ToString());
                            VimsoMoved = 0;
                            timeDifference = 0;
                        }

                        VimsoMoved = Convert.ToDecimal(Data[i].S4SL_ArcDist.ToString()) - Opening;
                        try
                        {
                            timeDifference = (Convert.ToDecimal(365.25 * Data[i].Vimso_pd) / Convert.ToDecimal(360.00 / 27.00)) * VimsoMoved;
                        }
                        catch { }
                        Data[i].Index = i;
                        Data[i].vimsoMoved = VimsoMoved;
                        Data[i].timeDifference = timeDifference;
                        try
                        {
                            Data[i].newDate = currentDate.AddSeconds(Convert.ToDouble(timeDifference) * 24 * 60 * 60);
                            Data[i].strNewDate = currentDate.AddSeconds(Convert.ToDouble(timeDifference) * 24 * 60 * 60).ToString("MM/dd/yyyy hh:mm:ss");
                        }
                        catch { }


                        objCalculatedList.Add(Data[i]);
                        if (i == Data.Count - 1)
                        {
                            objCalculatedList[objCalculatedList.Count - 1].isLast = true;
                        }
                        if (i < Data.Count - 1 && Data[i].GroupId != Data[i + 1].GroupId)
                        {
                            var current = Data[i].S4SL_ArcDist;
                            var next = Data[i + 1].S4SL_ArcDist;
                            // calculate current tgroup closing on group change
                            decimal LastValue = Convert.ToDecimal(Data[i].S4SL_ArcDist.ToString());
                            Closing = (Convert.ToDecimal(360.00 / 27.00) * Convert.ToDecimal(Data[i].Di_Gp));

                            objCalculatedList[objCalculatedList.Count - 1].S4SL_ArcDist = Closing.ToString();
                            objCalculatedList[objCalculatedList.Count - 1].isLast = true;

                            // adding new opening row on group change
                            objCalculatedList.Add(new tblVimsoChartResponse
                            {
                                GroupId = Data[i + 1].GroupId,
                                GroupName = Data[i + 1].GroupName,
                                Vimso_pd = Data[i + 1].Vimso_pd,
                                Index = Data[i + 1].Index,
                                StarLord = Data[i + 1].StarLord,
                                Di_Gp = Data[i + 1].Di_Gp,
                                Pu_Gp = Data[i + 1].Pu_Gp,
                                An_Gp = Data[i + 1].An_Gp,
                                So_Gp = Data[i + 1].So_Gp,
                                S1SL = Data[i + 1].S1SL,
                                S2SL = Data[i + 1].S2SL,
                                S3SL = Data[i + 1].S3SL,
                                S4SL = Data[i + 1].S4SL,
                                S4SL_ArcDist = Data[i + 1].S4SL_ArcDist,
                                vimsoMoved = Data[i + 1].vimsoMoved,
                                timeDifference = Data[i + 1].timeDifference,
                                newDate = Data[i + 1].newDate,
                                DOB = Data[i + 1].DOB,
                                isLast = Data[i + 1].isLast,
                            });

                            if (LastValue < Convert.ToDecimal(359.99))
                                Opening = Closing;
                            else
                                Opening = 0;

                            VimsoMoved = 0;
                            timeDifference = 0;
                            currentDate = Data[i].newDate;
                            objCalculatedList[objCalculatedList.Count - 1].S4SL_ArcDist = Opening.ToString();
                            objCalculatedList[objCalculatedList.Count - 1].vimsoMoved = VimsoMoved;
                            objCalculatedList[objCalculatedList.Count - 1].timeDifference = timeDifference;
                            objCalculatedList[objCalculatedList.Count - 1].newDate = currentDate.AddSeconds(Convert.ToDouble(timeDifference) * 24 * 60 * 60);
                            objCalculatedList[objCalculatedList.Count - 1].strNewDate = currentDate.AddSeconds(Convert.ToDouble(timeDifference) * 24 * 60 * 60).ToString("MM/dd/yyyy hh:mm:ss");
                        }
                    }

                    if (isDissai)
                        HttpContext.Session.SetString(Enums.SessionVimsoChart.DissaiData.ToString(), JsonConvert.SerializeObject(objCalculatedList).ToString());
                }
                var result = objCalculatedList.Where(t => t.isLast == true).ToList();
                return JsonConvert.SerializeObject(result);

            }
            return "";
        }

        [HttpPost]
        public IActionResult getPuthiChart(int IDs, int Group)
        {
            if (HttpContext.Session.GetString(Enums.SessionVimsoChart.Data.ToString()) == null)
            {
                try
                {
                    getVimsoChart(IDs);
                }
                catch { }
            }
            string strResponse = "";
            //var objCalculatedList = JsonConvert.DeserializeObject<List<tblVimsoChartResponse>>(HttpContext.Session.GetString(Enums.SessionVimsoChart.Data.ToString()).ToString());
            var selectedList = JsonConvert.DeserializeObject<List<tblVimsoChartResponse>>(HttpContext.Session.GetString(Enums.SessionVimsoChart.Data.ToString()).ToString()).Where(t => t.Di_Gp == Group).Select<tblVimsoChartResponse, tblVimsoChartResponse>(x => new tblVimsoChartResponse
            {
                Index = x.Index,
                Vimso_pd = x.Vimso_pd,
                StarLord = x.StarLord,
                Di_Gp = x.Di_Gp,
                Pu_Gp = x.Pu_Gp,
                An_Gp = x.An_Gp,
                So_Gp = x.So_Gp,
                S1SL = x.S1SL,
                S2SL = x.S2SL,
                S3SL = x.S3SL,
                S4SL = x.S4SL,
                GroupName = x.S1SL,
                GroupId = x.Pu_Gp,
                S4SL_ArcDist = x.S4SL_ArcDist,
                vimsoMoved = x.vimsoMoved,
                timeDifference = x.timeDifference,
                newDate = x.newDate,
                strNewDate = x.strNewDate,
                DOB = x.DOB,
                isLast = x.isLast,
            }).ToList();
            strResponse = getVimsoData(selectedList);
            return Json(strResponse);
        }
        [HttpPost]
        public IActionResult GetAntraChart(int IDs, int Group)
        {
            if (HttpContext.Session.GetString(Enums.SessionVimsoChart.Data.ToString()) == null)
            {
                try
                {
                    getVimsoChart(IDs);
                }
                catch { }
            }
            List<AntraSoksuma> objAntraList = new List<AntraSoksuma>();
            var objCalculatedList = JsonConvert.DeserializeObject<List<tblVimsoChartResponse>>(HttpContext.Session.GetString(Enums.SessionVimsoChart.Data.ToString()).ToString());
            var puthiList = objCalculatedList.Where(t => t.Pu_Gp == Group).Select<tblVimsoChartResponse, tblVimsoChartResponse>(x => new tblVimsoChartResponse
            {
                Index = x.Index,
                Vimso_pd = x.Vimso_pd,
                StarLord = x.StarLord,
                Di_Gp = x.Di_Gp,
                Pu_Gp = x.Pu_Gp,
                An_Gp = x.An_Gp,
                So_Gp = x.So_Gp,
                S1SL = x.S1SL,
                S2SL = x.S2SL,
                S3SL = x.S3SL,
                S4SL = x.S4SL,
                GroupName = x.S2SL,
                GroupId = x.An_Gp,
                S4SL_ArcDist = x.S4SL_ArcDist,
                vimsoMoved = x.vimsoMoved,
                timeDifference = x.timeDifference,
                newDate = x.newDate,
                strNewDate = x.strNewDate,
                DOB = x.DOB,
                isLast = x.isLast,
            }).ToList();
            var antraData = JsonConvert.DeserializeObject<List<tblVimsoChartResponse>>(getVimsoData(puthiList).ToString());
            foreach (var antra in antraData)
            { //foreach of 9 antras we are loading their soksumas table
                var antraList = objCalculatedList.Where(t => t.An_Gp == antra.An_Gp).Select<tblVimsoChartResponse, tblVimsoChartResponse>(x => new tblVimsoChartResponse
                {
                    Index = x.Index,
                    Vimso_pd = x.Vimso_pd,
                    StarLord = x.StarLord,
                    Di_Gp = x.Di_Gp,
                    Pu_Gp = x.Pu_Gp,
                    An_Gp = x.An_Gp,
                    So_Gp = x.So_Gp,
                    S1SL = x.S1SL,
                    S2SL = x.S2SL,
                    S3SL = x.S3SL,
                    S4SL = x.S4SL,
                    GroupName = x.S3SL,
                    GroupId = x.So_Gp,
                    S4SL_ArcDist = x.S4SL_ArcDist,
                    vimsoMoved = x.vimsoMoved,
                    timeDifference = x.timeDifference,
                    newDate = x.newDate,
                    strNewDate = x.strNewDate,
                    DOB = x.DOB,
                    isLast = x.isLast,
                }).ToList();

                var SoksumaData = JsonConvert.DeserializeObject<List<tblVimsoChartResponse>>(getVimsoData(antraList).ToString());
                objAntraList.Add(new AntraSoksuma { Antra = antra, Soksumas = SoksumaData });

            }
            return Json(JsonConvert.SerializeObject(objAntraList));
        }

        [HttpPost]
        public IActionResult GetPranaChart(int IDs, int Group)
        {
            if (HttpContext.Session.GetString(Enums.SessionVimsoChart.Data.ToString()) == null)
            {
                try
                {
                    getVimsoChart(IDs);
                }
                catch { }
            }
            string strResponse = "";
            var objCalculatedList = JsonConvert.DeserializeObject<List<tblVimsoChartResponse>>(HttpContext.Session.GetString(Enums.SessionVimsoChart.Data.ToString()).ToString());
            var selectedList = objCalculatedList.Where(t => t.So_Gp == Group).Select<tblVimsoChartResponse, tblVimsoChartResponse>(x => new tblVimsoChartResponse
            {
                Index = x.Index,
                Vimso_pd = x.Vimso_pd,
                StarLord = x.StarLord,
                Di_Gp = x.Di_Gp,
                Pu_Gp = x.Pu_Gp,
                An_Gp = x.An_Gp,
                So_Gp = x.So_Gp,
                S1SL = x.S1SL,
                S2SL = x.S2SL,
                S3SL = x.S3SL,
                S4SL = x.S4SL,
                GroupName = x.S4SL,
                GroupId = x.Index,
                S4SL_ArcDist = x.S4SL_ArcDist,
                vimsoMoved = x.vimsoMoved,
                timeDifference = x.timeDifference,
                newDate = x.newDate,
                strNewDate = x.strNewDate,
                DOB = x.DOB,
                isLast = x.isLast,
            }).ToList();
            strResponse = getVimsoData(selectedList);
            return Json(JsonConvert.SerializeObject(selectedList));
        }

    }
}

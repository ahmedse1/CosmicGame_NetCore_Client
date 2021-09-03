using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Response
{
    public class tblVimsoChartResponse
    {
        public int Index { get; set; }
        public int Vimso_pd { get; set; }
        public string StarLord { get; set; }
        public string GroupName { get; set; }
        public int GroupId { get; set; }
        public int Di_Gp { get; set; }
        public int Pu_Gp { get; set; }
        public int An_Gp { get; set; }
        public int So_Gp { get; set; }
        public string S1SL { get; set; }
        public string S2SL { get; set; }
        public string S3SL { get; set; }
        public string S4SL { get; set; }
        public string S4SL_ArcDist { get; set; }
        public decimal vimsoMoved { get; set; }
        public decimal timeDifference { get; set; }
        public DateTime newDate { get; set; }
        public string strNewDate { get; set; }
        public DateTime DOB { get; set; }
        public bool isLast { get; set; } = false;
    }

    public class AntraSoksuma
    {
        public tblVimsoChartResponse Antra { get; set; }
        public List<tblVimsoChartResponse> Soksumas { get; set; }
    }

    public class VimsoChartCell
    {
        public int Gp { get; set; }
        public string StarLord { get; set; }
        public DateTime Date { get; set; }
    }

}

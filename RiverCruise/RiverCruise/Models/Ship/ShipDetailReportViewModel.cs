using System;

namespace RiverCruise.Models.Ship
{
    public class ShipDetailReportViewModel
    {
        private DateTime _date;

        public ShipDetailReportViewModel(DataModels.Report report)
        {
            Ref = report.Ref;
            _date = report.Date;
            Remarks = report.Remarks;
        }

        public string Date { get { return _date.Equals(new DateTime()) ? "-" : _date.ToString("mmmm dd yyyy"); } }
        public string Ref { get; set; }
        public string Remarks { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace RiverCruise.Models.Ship
{
    public class ShipReportViewModel
    {
        private DateTime _lastReport;

        public ShipReportViewModel(List<DataModels.Report> reports)
        {
            var firstOrDefault = reports.OrderByDescending(o => o.Date).FirstOrDefault();
            if (firstOrDefault != null)
            {
                _lastReport = reports.Any() ? firstOrDefault.Date : new DateTime();
            }
            Count = reports.Count;
        }

        //public List<ShipDetailReportViewModel> Reports { get; set; }

        public int Count{ get; set; }

        public string LastReport
        {
            get
            {
                return _lastReport.Equals(new DateTime()) ? "-" : _lastReport.ToString("mmmm dd yyyy");
            }
        }
    }
}
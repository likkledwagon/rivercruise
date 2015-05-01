using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataModels;

namespace RiverCruise.Models.Ship
{
    public class ShipReportViewModel
    {
        private DateTime _lastReport;

        public ShipReportViewModel(Collection<Report> reports)
        {
            var firstOrDefault = reports.OrderByDescending(o => o.Date).FirstOrDefault();
            if (firstOrDefault != null)
            {
                _lastReport = reports.Any() ? firstOrDefault.Date : new DateTime();
            }
            Count = reports.Count();
        }

        //public List<ShipDetailReportViewModel> Reports { get; set; }

        public int Count{ get; set; }

        public string LastReport
        {
            get
            {
                return _lastReport.Equals(new DateTime()) ? "-" : _lastReport.ToString("MM dd yyyy");
            }
        }
    }
}
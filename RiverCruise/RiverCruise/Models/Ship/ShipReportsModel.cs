using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DataModels;

namespace RiverCruise.Models.Ship
{
    public class ShipReportsModel : BasePagingModel
    {
        public ShipReportsModel(IEnumerable<Report> reports, int page, int totalItems, int shipId)
        {
            Reports = reports.OrderByDescending(y => y.Date).Skip((page - 1) * ItemsPerPage).Take(ItemsPerPage).Select(x => new ShipReportModel(x));
            Action = "ShipHistory";
            Initialize(page, totalItems, "Home");
            ShipId = shipId;
        }

        public IEnumerable<ShipReportModel> Reports { get; set; }
        public int ShipId { get; set; }
    }

    public class ShipReportModel
    {
        private int _id;

        [Display(Name = "Date of visit")]
        public DateTime DateOfVisit { get; set; }

        public string Port { get; set; }

        public int CompanyId { get; set; }
        public int Id { get; set; }

        public ShipReportModel(Report report)
        {
            _id = report.Id;
            DateOfVisit = report.Date;
            Port = report.Port;
            Id = report.Id;
        }
    }
}
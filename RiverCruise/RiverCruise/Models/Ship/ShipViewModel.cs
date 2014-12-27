using System;
using System.Linq;

namespace RiverCruise.Models.Ship
{
    public class ShipViewModel
    {
        public ShipViewModel(DataModels.Ship ship)
        {
            Name = ship.Name;
            Id = ship.Id;
            Region = ship.Region;
            var company = ship.Ship2Company;
            Company = ship.Ship2Company.First(x => (x.From < DateTime.Now) && (DateTime.Now <= x.Until)).Company.Name;
            CompanyId = ship.Ship2Company.First(x => (x.From < DateTime.Now) && (DateTime.Now <= x.Until)).Company.Id;
            ShipReportViewModel = new ShipReportViewModel(ship.Reports.ToList());
        }

        public string Region { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public ShipReportViewModel ShipReportViewModel { get; set; }
        public int CompanyId { get; set; }
    }
}
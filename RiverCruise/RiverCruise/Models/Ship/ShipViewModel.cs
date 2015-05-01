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
            Eni = ship.Eni;
            Company = ship.Ship2Company.First(x => (x.From < DateTime.Now) && (DateTime.Now <= x.Until)).Company.Name;
            CompanyId = ship.Ship2Company.First(x => (x.From < DateTime.Now) && (DateTime.Now <= x.Until)).Company.Id;
            ShipReportViewModel = new ShipReportViewModel(ship.Reports);
        }

        public string Region { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public string Eni { get; set; }

        public ShipReportViewModel ShipReportViewModel { get; set; }

        public int CompanyId { get; set; }
    }
}
namespace RiverCruise.Models.Ship
{
    public class ShipViewModel
    {
        public ShipViewModel(DataModels.Ship ship)
        {
            Name = ship.Name;
            Id = ship.Id;
            Region = ship.Region;
            Company = ship.Company.Name;
            CompanyId = ship.Company.Id;
            ShipReportViewModel = new ShipReportViewModel(ship.Reports);
        }

        public string Region { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public ShipReportViewModel ShipReportViewModel { get; set; }
        public int CompanyId { get; set; }
    }
}
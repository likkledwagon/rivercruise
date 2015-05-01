using System.Linq;
using DataModels;

namespace RiverCruise.Models.Company
{
    public class CompanyshipsModel
    {
        public CompanyshipsModel(Ship2Company shipCompany)
        {
            Name = shipCompany.Ship.Name;
            Id = shipCompany.Ship.Id;
            LastReport = "-";
            if (shipCompany.Ship.Reports.Any())
            {
                LastReport = shipCompany.Ship.Reports.OrderByDescending(x => x.Date).Select(y => y.Date).First().ToString("MM/dd/yyyy");
            }
            Reports = shipCompany.Ship.Reports.Count;
        }

        public CompanyshipsModel()
        {
            
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public int Reports { get; set; }
        public string LastReport { get; set; }
    }
}
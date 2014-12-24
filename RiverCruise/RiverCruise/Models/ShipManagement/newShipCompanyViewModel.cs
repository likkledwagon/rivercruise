using System.ComponentModel.DataAnnotations;

namespace RiverCruise.Models.ShipManagement
{
    public class NewShipCompanyViewModel
    {
        [Display(Name = "Company name")]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
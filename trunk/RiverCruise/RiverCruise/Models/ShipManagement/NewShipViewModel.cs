using System.ComponentModel.DataAnnotations;

namespace RiverCruise.Models.ShipManagement
{
    public class NewShipViewModel
    {
        public NewShipCompanyViewModel Comany { get; set; }

        [Required]
        public string Name { get; set; }
        public string Eni { get; set; }
        public int NauticalCrew { get; set; }
        public int HotselStaff { get; set; }
        public string Region { get; set; }
    }
}
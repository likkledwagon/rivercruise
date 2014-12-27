using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;

namespace RiverCruise.Models.ShipManagement
{
    public class NewShipViewModel
    {
        public NewShipCompanyViewModel Comany { get; set; }

        [Required]
        public string Name { get; set; }
        public string Eni { get; set; }

        [Display(Name = "Nautical crew")]
        public int NauticalCrew { get; set; }

        [Display(Name="Hotel staff")]
        public int HotselStaff { get; set; }
        public string Region { get; set; }

        [StringLength(3)]
        public string Flag { get; set; }
        public bool ShipAdded { get; set; }
    }
}
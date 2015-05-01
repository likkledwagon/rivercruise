using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace RiverCruise.Models.ShipManagement
{
    public class AddReportViewModel
    {
        public AddReportViewModel()
        {
        }

        public AddReportViewModel(int id)
        {
            Id = id;
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime DateOfVisit { get; set; }

        [Required]
        public HttpPostedFileBase File { get; set; }

        public string Port { get; set; }
    }
}
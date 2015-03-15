using System.ComponentModel.DataAnnotations;

namespace RiverCruise.Models.CompanyManagement
{
    public class NewCompanyModel
    {
        public NewCompanyModel()
        {
        }

        public NewCompanyModel(bool companyAdded = false)
        {
            CompanyAdded = companyAdded;
        }

        [Required]
        public string Name { get; set; }

        public string Website { get; set; }

        public bool CompanyAdded { get; set; }

        [Display(Name = "Crewing agent")]
        public string CrewingAgent { get; set; }

        [Display(Name = "Crewing agent website")]
        public string CrewingAgentWebsite { get; set; }
    }
}
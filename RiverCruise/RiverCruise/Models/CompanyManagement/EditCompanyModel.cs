using System.ComponentModel.DataAnnotations;

namespace RiverCruise.Models.CompanyManagement
{
    public class EditCompanyModel
    {
        public EditCompanyModel()
        {
        }

        public EditCompanyModel(DataModels.Company company, bool modified = false)
        {
            Name = company.Name;
            Id = company.Id;
            CompanyModified = modified;
            Website = company.Website;
            CrewingAgent = company.CrewingAgent;
            CrewingAgentWebsite = company.CrewingAgentWebsite;
        }

        [Display(Name = "Crewing agent website")]
        public string CrewingAgentWebsite { get; set; }

        [Display(Name = "Crewing agent")]
        public string CrewingAgent { get; set; }

        public string Website { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
        public bool CompanyModified { get; set; }
    }
}
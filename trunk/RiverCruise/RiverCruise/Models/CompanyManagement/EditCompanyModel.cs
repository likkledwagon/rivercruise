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
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public bool CompanyModified { get; set; }
    }
}
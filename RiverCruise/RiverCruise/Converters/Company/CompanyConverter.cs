using Data.ProxyModel.Company;
using RiverCruise.Models.CompanyManagement;

namespace RiverCruise.Converters.Company
{
    public static class CompanyConverter
    {
        public static EditCompanyProxyModel ToEditCompanyProxyModel(this EditCompanyModel model)
        {
            return new EditCompanyProxyModel()
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public static NewCompanyProxyModel ToNewCompanyProxyModel(this NewCompanyModel model)
        {
            return new NewCompanyProxyModel()
            {
                Name = model.Name
            };
        }
    }
}
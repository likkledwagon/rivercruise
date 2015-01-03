using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Data.ProxyModel.Ship;
using DataModels;
using RiverCruise.Models.CompanyManagement;
using RiverCruise.Validation;

namespace RiverCruise.Models.ShipManagement
{
    public class ChangeCompanymodel
    {
        public ChangeCompanymodel(int id, Ship2Company currentCompany, IQueryable<DataModels.Company> companyOptions)
        {
            ShipId = id;
            CurrentCompanyName = currentCompany.Company.Name;
            CurrentCompanySince = currentCompany.From;
            NewCompanySince = DateTime.Now;
        }

        public ChangeCompanymodel()
        {
        }

        public int ShipId { get; set; }
        public bool CompanyChanged { get; set; }

        [Display(Name="Current Company")]
        public string CurrentCompanyName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "MM/dd/yy")]
        public DateTime CurrentCompanySince { get; set; }

        [Display(Name="New Company")]
        public string NewCompany { get; set; }

        [DateValidation(ErrorMessage = "Date must be between 1/01/1900 and current date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NewCompanySince { get; set; }

        public ChangeCompanyProxyModel ToChangeCompanyProxyModel()
        {
            return new ChangeCompanyProxyModel()
            {
                ShipId = ShipId,
                NewCompanyName = NewCompany,
                Since = NewCompanySince
            };
        }
    }
}
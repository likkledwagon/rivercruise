using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RiverCruise.Models.Company
{
    public class CompaniesOverviewViewModel : BasePagingModel
    {
        public CompaniesOverviewViewModel(DbSet<DataModels.Company> companies, int currentPage, int totalItems, string searchText, bool companyDeleted)
        {
            TotalItems = totalItems;
            Companies = companies.Select(x => new CompanyOverviewViewModel()
            {
                Id = x.Id,
                Name = x.Name,

                Ships = x.Ship2Company.Any(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)) ? x.Ship2Company.Count(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)) : 0,
            }).Where(w => searchText == null || w.Name.Contains(searchText)).OrderBy(y=> y.Name).Skip((currentPage -1)*ItemsPerPage).Take(ItemsPerPage).ToList();

            Initialize(currentPage, totalItems, "Company");
            SearchText = searchText;

            CompanyDeleted = companyDeleted;
        }

        public bool CompanyDeleted { get; set; }

        public List<CompanyOverviewViewModel> Companies { get; set; }
    }

    public class CompanyOverviewViewModel
    {
        public string Name { get; set; }
        public int Ships { get; set; }
        public int Id { get; set; }
    }
}
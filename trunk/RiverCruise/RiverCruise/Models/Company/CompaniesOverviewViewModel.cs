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
                Ships = x.Ship2Company.Any() ? x.Ship2Company.Count(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)) : 0,
                NauticalCrew = x.Ship2Company.Any() ? x.Ship2Company.Where(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until))
                    .SelectMany(z => z.Ship.Crew).Where(c => c.From < DateTime.Now && c.Until >= DateTime.Now)
                    .Sum(r => r.NauticalCrew != null ? r.NauticalCrew.Value : 0) : 0,
                HotelStaff = x.Ship2Company.Any() ? x.Ship2Company.Where(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until))
                    .SelectMany(z => z.Ship.Crew).Where(c => c.From < DateTime.Now && c.Until >= DateTime.Now)
                    .Sum(r => r.HotelStaff != null ? r.HotelStaff.Value : 0) : 0,
                Reports = x.Reports.Count(),
                ShipsVisited = x.Ship2Company.Any() ? x.Ship2Company.Count(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until) && y.Ship.Reports.Count > 0) : 0
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
        public int NauticalCrew { get; set; }
        public int HotelStaff { get; set; }
        public int Reports { get; set; }
        public int ShipsVisited { get; set; }
        public int Id { get; set; }
    }
}
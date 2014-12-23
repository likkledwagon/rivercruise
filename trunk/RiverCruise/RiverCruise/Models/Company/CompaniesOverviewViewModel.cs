using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RiverCruise.Models.Company
{
    public class CompaniesOverviewViewModel : BasePagingModel
    {
        public CompaniesOverviewViewModel(DbSet<DataModels.Company> companies, int currentPage, int totalItems, string searchText)
        {
            TotalItems = totalItems;
            Companies = companies.Select(x => new CompanyOverviewViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Ships = x.Ships.Count(),
                NauticalCrew = x.Ships.Sum(s => s.NauticalCrew != null ? s.NauticalCrew.Value : 0),
                HotelStaff = x.Ships.Sum(s => s.HotelStaff != null ? s.HotelStaff.Value : 0),
                Reports = x.Reports.Count(),
                ShipsVisited = x.Ships.Count(q => q.Reports.Count > 0)
            }).Where(w => searchText == null || w.Name.Contains(searchText)).OrderBy(y=> y.Name).Skip((currentPage -1)*ItemsPerPage).Take(ItemsPerPage).ToList();

            Initialize(currentPage, totalItems, "Company");
            SearchText = searchText;
        }

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
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RiverCruise.Helpers;

namespace RiverCruise.Models.Ship
{
    public class ShipsOverviewViewModel : BasePagingModel
    {
        public ShipsOverviewViewModel(DbSet<DataModels.Ship> queryResult, int page, int totalItems, string searchText, SearchOption searchType)
        {
            switch (searchType)
            {
                case SearchOption.Eni: ItemsList = queryResult
                    .Where(w => searchText == null || w.Eni.Contains(searchText))
                    .OrderBy(x => x.Name)
                    .Skip(ItemsPerPage * (page - 1))
                    .Take(ItemsPerPage).ToList()
                    .Select(s => new ShipViewModel(s))
                    .ToList();
                    break;
                default:
                    ItemsList = queryResult
                    .Where(w => searchText == null || w.Name.Contains(searchText))
                    .OrderBy(x => x.Name)
                    .Skip(ItemsPerPage * (page - 1))
                    .Take(ItemsPerPage).ToList()
                    .Select(s => new ShipViewModel(s))
                    .ToList();
                    break;

            }
            
            Initialize(page, totalItems, "Home");
            SearchText = searchText;
            base.Action = "Ships";
        }

        public List<ShipViewModel> ItemsList { get; set; }
    }
}
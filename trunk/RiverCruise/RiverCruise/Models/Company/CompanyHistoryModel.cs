using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DataModels;

namespace RiverCruise.Models.Company
{
    public class CompanyHistoryModel : BasePagingModel
    {
        public CompanyHistoryModel(IEnumerable<Ship2Company> ship2Company, int page, int totalItems)
        {
            Ships = ship2Company.OrderByDescending(z => z.From).Skip((page - 1) * ItemsPerPage).Take(ItemsPerPage).Select(x => new CompanyShipHistoryModel(x))
                .ToList();

            Action = "CompanyHistory";

            Initialize(page, totalItems, "Company");
        }

        public List<CompanyShipHistoryModel> Ships { get; set; }
    }
}
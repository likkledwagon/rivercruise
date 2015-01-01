using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DataModels;

namespace RiverCruise.Models.Company
{
    public class CompanyHistoryModel : BasePagingModel
    {
        public CompanyHistoryModel(IEnumerable<Ship2Company> ship2Company, IQueryable<Ship2Company> querySold, int page, int totalItems)
        {
            Ships = ship2Company.Select(x => new CompanyShipHistoryModel
            {
                Date = x.From,
                HistoryType = HistoryType.In,
                ShipId = x.Ship.Id,
                ShipName = x.Ship.Name
            })
                .Concat(querySold.Select(y => new CompanyShipHistoryModel
                {
                    Date = y.Until,
                    HistoryType = HistoryType.Out,
                    ShipId = y.Ship.Id,
                    ShipName = y.Ship.Name
                }))
                .OrderByDescending(q => q.Date).Skip((page - 1)*ItemsPerPage).Take(ItemsPerPage).ToList();

            Action = "CompanyHistory";

            Initialize(page, totalItems, "Company");
        }

        public List<CompanyShipHistoryModel> Ships { get; set; }
    }

}
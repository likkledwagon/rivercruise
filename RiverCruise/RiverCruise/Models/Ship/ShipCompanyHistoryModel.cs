using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using DataModels;

namespace RiverCruise.Models.Ship
{
    public class ShipCompanyHistoryModel:BasePagingModel
    {
        public ShipCompanyHistoryModel(IEnumerable<Ship2Company> ship2Company, int page, int totalItems)
        {
            Companies = ship2Company.OrderByDescending(o => o.From)
                .Skip((page-1)*ItemsPerPage).Take(ItemsPerPage)
                .Select(x => new ShipCompanyHistoryCompanyModel()
                {
                    From = x.From,
                    Until = x.Until,
                    Company = x.Company == null ? "????" : x.Company.Name,
                    CompanyId = x.Company == null ? -1 : x.Company.Id
                });
            Initialize(page, totalItems, "Home");
        }

        public IEnumerable<ShipCompanyHistoryCompanyModel> Companies { get; set; }
    }

    public class ShipCompanyHistoryCompanyModel
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime From { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Until { get; set; }

        public string Company { get; set; }
        public int CompanyId { get; set; }
    }
}
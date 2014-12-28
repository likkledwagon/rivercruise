using System;
using DataModels;

namespace RiverCruise.Models.Company
{
    public class CompanyShipHistoryModel : CompanyshipsModel
    {
        public CompanyShipHistoryModel(Ship2Company shipCompany) : base(shipCompany)
        {
            From = shipCompany.From;
            Until = shipCompany.Until;
        }

        public DateTime Until { get; set; }

        public DateTime From { get; set; }
    }
}
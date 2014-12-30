using System;
using DataModels;

namespace RiverCruise.Models.Company
{
    public class CompanyShipHistoryModel : CompanyshipsModel
    {
        private DateTime _until;
        private DateTime _from;

        public CompanyShipHistoryModel(Ship2Company shipCompany) : base(shipCompany)
        {
            _from = shipCompany.From;
            _until = shipCompany.Until;
        }

        public string Until
        {
            get { return _until.ToString("mmmm dd yyyy"); }
        }

        public string From
        {
            get { return _from.ToString("mmmm dd yyyy"); }
        }
    }
}
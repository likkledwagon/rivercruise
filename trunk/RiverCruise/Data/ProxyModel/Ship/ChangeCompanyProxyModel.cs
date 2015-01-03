using System;

namespace Data.ProxyModel.Ship
{
    public class ChangeCompanyProxyModel
    {
        public int ShipId { get; set; }
        public string NewCompanyName { get; set; }
        public DateTime Since { get; set; }
    }
}
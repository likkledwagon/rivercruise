using System;

namespace Data.ProxyModel.Ship
{
    public class AddReportProxyModel
    {
        public AddReportFileProxyModel Report { get; set; }
        public string Port { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int ShipId { get; set; }
    }
}
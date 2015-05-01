using System;

namespace Data.ProxyModel.Ship
{
    public class EditShipProxyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Eni { get; set; }
        public string Flag { get; set; }
        public string Region { get; set; }
        public int? HotelStaff { get; set; }
        public int? NauticalCrew { get; set; }
        public DateTime Since { get; set; }
        public string Remark { get; set; }
    }
}
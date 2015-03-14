namespace Data.ProxyModel.Ship
{
    public class AddFileToShipProxyModel
    {
        public int ShipId { get; set; }
        public byte[] Bytes { get; set; }
        public string Type { get; set; }
        public string FileName { get; set; }
    }
}
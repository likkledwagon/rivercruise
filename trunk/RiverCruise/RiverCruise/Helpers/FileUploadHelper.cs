using System.IO;
using System.Web;
using Data.ProxyModel.Ship;

namespace RiverCruise.Helpers
{
    public class FileUploadHelper
    {
        public static AddFileToShipProxyModel UploadFile(HttpPostedFileBase hpf, int shipId)
        {
            var reader = new BinaryReader(hpf.InputStream);
            var bytes = reader.ReadBytes(hpf.ContentLength);
            var fileName = Path.GetFileName(hpf.FileName);
            var type = hpf.ContentType;

            return new AddFileToShipProxyModel()
            {
                ShipId = shipId,
                Bytes = bytes,
                Type = type,
                FileName = fileName
            };
        }
    }
}
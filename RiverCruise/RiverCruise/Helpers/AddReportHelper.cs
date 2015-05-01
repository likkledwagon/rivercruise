using System.IO;
using Data.ProxyModel.Ship;
using RiverCruise.Models.ShipManagement;

namespace RiverCruise.Helpers
{
    public class AddReportHelper
    {
        public static AddReportProxyModel CreatetProxyModel(AddReportViewModel report)
        {
            var reader = new BinaryReader(report.File.InputStream);
            var bytes = reader.ReadBytes(report.File.ContentLength);
            var file = new AddReportFileProxyModel()
            {
                Name = report.File.FileName,
                Length = report.File.ContentLength,
                Type = report.File.ContentType,
                Content = bytes
            };
            var addreportProxyModel = new AddReportProxyModel()
            {
                Report = file,
                Port = report.Port,
                DateOfVisit = report.DateOfVisit,
                ShipId = report.Id
            };
            return addreportProxyModel;
        } 
    }
}
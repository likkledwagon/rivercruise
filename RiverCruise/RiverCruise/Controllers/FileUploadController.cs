using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Data.ProxyModel.Ship;
using RiverCruise.Helpers;
using RiverCruise.Models.Shared;

namespace RiverCruise.Controllers
{
    public class FileUploadController : BaseController
    {
        [HttpPost]
        [Authorize(Roles = "Edit")]
        public ContentResult UploadFiles(int id)
        {
            var r = new List<UploadFilesResult>();

            foreach (string file in Request.Files)
            {
                var hpf = Request.Files[file];
                if (hpf == null || hpf.ContentLength == 0)
                    continue;
                AddFileToShipProxyModel uploadFile = FileUploadHelper.UploadFile(hpf, id);

                
                _db.AddFileToShip(uploadFile);

                r.Add(new UploadFilesResult()
                {
                    Name = hpf.FileName,
                    Length = hpf.ContentLength,
                    Type = hpf.ContentType
                });
            }
            
            return Content("{\"name\":\"" + r[0].Name + "\",\"type\":\"" + r[0].Type + "\",\"size\":\"" + string.Format("{0} bytes", r[0].Length) + "\"}", "application/json");
        }

        public ActionResult DownloadFile(int id)
        {
            var file = _db.Attachements.Find(id);
            byte[] byteInfo = file.FileBytes;
            var ms = new MemoryStream();
            ms.Write(byteInfo, 0, byteInfo.Length);
            ms.Position = 0;

            return new FileStreamResult(ms, file.Type);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Edit")]
        public ActionResult DeleteFile(int id)
        {
            int shipId = _db.DeleteFile(id);

            return RedirectToAction("Detail", "Home", new {Id = shipId});
        }

        [HttpGet]
        [Authorize(Roles = "Edit")]
        public ActionResult DeleteFileGet(int id)
        {
            var modalModel = new ModalModel()
            {
                Action = "DeleteFile",
                Arguments = new Dictionary<string, object>() { { "id", id } },
                Body = "Are you sure you want to delete this file?",
                Controller = "FileUpload",
                Title = "Confirm"
            };

            return PartialView("Modal", modalModel);
        }
    }
}

public class UploadFilesResult
{
    public string Name { get; set; }
    public int Length { get; set; }
    public string Type { get; set; }
}
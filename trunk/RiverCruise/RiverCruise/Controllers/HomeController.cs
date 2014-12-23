using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using Data;
using DataModels;
using RiverCruise.Models;
using System.Linq;
using System.Web.Mvc;
using RiverCruise.Models.Ship;

namespace RiverCruise.Controllers
{
    public class HomeController : BaseController
    {
        [Authorize]
        public ActionResult AutoComplete(string term)
        {
            var model = _db.Ships.
                Where(r => r.Name.StartsWith(term)).Take(10)
                .Select(r => new {label = r.Name});

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        public ActionResult Index(string searchText, int page = 1)
        {
            if (page < 1)
            {
                page = 1;
            }

            var totalShips = _db.Ships.Count(w => searchText == null || w.Name.Contains(searchText));
            var shipsModel = new ShipsOverviewViewModel(_db.Ships, page, totalShips, searchText);

            if (Request.IsAjaxRequest())
            {
                return PartialView("~/Views/Home/_Ships.cshtml", shipsModel);
            }

            return View(shipsModel);
        }

        [Authorize]
        public ActionResult Detail(int id)
        {
            var queryResult = _db.Ships.Find(id);
            if (queryResult == null)
            {
                return HttpNotFound();
            }

            return View(new ShipDetailModel(queryResult));
        }
    }
}

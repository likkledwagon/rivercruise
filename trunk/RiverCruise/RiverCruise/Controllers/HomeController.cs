using System;
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
        public ActionResult AutoComplete(string term)
        {
            var model = _db.Ships.
                Where(r => r.Name.StartsWith(term)).Take(10)
                .Select(r => new {label = r.Name});

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult WhatsNew()
        {
            return View("WhatsNew");
        }

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

        public ActionResult Detail(int id, bool deleteFailed = false)
        {
            var queryResult = _db.Ships.Find(id);
            if (queryResult == null)
            {
                return HttpNotFound();
            }

            return View(new ShipDetailModel(queryResult, deleteFailed));
        }

        public ActionResult ShipHistory(int id, int page = 1)
        {
            var query = _db.Ships.Find(id);
            if (query == null)
            {
                return HttpNotFound();
            }

            var totalItems = _db.Ships.Find(id).Crew.Count(x => x.Until < DateTime.Now);

            var model = new ShipHistoryModel(query.Crew.Where(x => x.Until < DateTime.Now), page, totalItems);

            return PartialView("~/Views/home/_shipHistory.cshtml", model);
        }
    }
}

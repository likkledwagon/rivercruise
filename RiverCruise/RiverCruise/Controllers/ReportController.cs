using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using RiverCruise.Models;
using RiverCruise.Models.Report;

namespace RiverCruise.Controllers
{
    public class ReportController : BaseController
    {
        public ActionResult Index(string searchText = null)
        {
            return View(new ReportsViewModel()
            {
                Reports = _db.Reports
                            .Where(w => searchText == null || w.Ref.Contains(searchText))
                            .OrderByDescending(x => x.Date)
                            .Include(I => I.Ship)
                            .ToList()
            });
        }
    }
}
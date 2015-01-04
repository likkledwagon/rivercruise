using System;
using System.Linq;
using System.Web.Mvc;
using RiverCruise.Models.Company;

namespace RiverCruise.Controllers
{
    public class CompanyController : BaseController
    {
        public ActionResult Index(string searchText = null, int page = 1, bool companyDeleted = false)
        {
            if (page < 1)
            {
                page = 1;
            }

            int totalItems = _db.Companies.Count(c => searchText== null || c.Name.Contains(searchText));
            var companiesOverviewViewModel = new CompaniesOverviewViewModel(_db.Companies, page, totalItems, searchText, companyDeleted);

            if (Request.IsAjaxRequest())
            {
                return PartialView("~/Views/Company/_Companies.cshtml", companiesOverviewViewModel);
            }

            return View(companiesOverviewViewModel);
        }

        public ActionResult Detail(int id, bool actionFailed = false)
        {
            var company = _db.Companies.Where(x => x.Id.Equals(id));
            if (!company.Any())
            {
                return HttpNotFound();
            }

            if (actionFailed)
            {
                ModelState.AddModelError("", "Failed to delete company, please try again. If you are trying to delete a company with active ships try removing them first.");
            }

            return View(new CompanyDetailViewModel(company.First()));
        }

        public ActionResult AutoComplete(string term)
        {
            var model = _db.Companies.
                Where(r => r.Name.StartsWith(term)).Take(10)
                .Select(r => new { label = r.Name });

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult CompanyHistory(int id, int page = 1)
        {
            // sold
            var totalItems = _db.Companies.Where(x => x.Id == id)
                .SelectMany(y => y.Ship2Company).Count(z => z.Until <= DateTime.Now);
            // acquired
            totalItems += _db.Companies.Where(x => x.Id == id)
                .SelectMany(y => y.Ship2Company).Count();

            var querySold= _db.Companies.Where(x => x.Id == id)
                .SelectMany(y => y.Ship2Company)
                .Where(x => x.Until <= DateTime.Now)
                .Select(a => a);

            var query = _db.Companies.Where(x => x.Id == id).SelectMany(y => y.Ship2Company);

            var model = new CompanyHistoryModel(query, querySold, page, totalItems);
            return PartialView("~/Views/Company/_companyHistory.cshtml", model);
        }
    }
}

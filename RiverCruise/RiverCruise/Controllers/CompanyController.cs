using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using RiverCruise.Models;
using RiverCruise.Models.Company;

namespace RiverCruise.Controllers
{
    public class CompanyController : BaseController
    {
        public ActionResult Index(string searchText = null, int page = 1)
        {
            if (page < 1)
            {
                page = 1;
            }

            int totalItems = _db.Companies.Count(c => searchText== null || c.Name.Contains(searchText));
            var companiesOverviewViewModel = new CompaniesOverviewViewModel(_db.Companies, page, totalItems, searchText);

            if (Request.IsAjaxRequest())
            {
                return PartialView("~/Views/Company/_Companies.cshtml", companiesOverviewViewModel);
            }

            return View(companiesOverviewViewModel);
        }

        public ActionResult Detail(int id)
        {
            var company = _db.Companies.Where(x => x.Id.Equals(id));
            if (!company.Any())
            {
                return HttpNotFound();
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
            int totalItems = _db.Companies.Where(x => x.Id == id)
                .SelectMany(y => y.Ship2Company).Count(z => z.Until <= DateTime.Now);

            var query = _db.Companies.Where(x => x.Id == id)
                .SelectMany(y => y.Ship2Company)
                .Where(z => z.Until <= DateTime.Now)
                .Select(a => a);

            var model = new CompanyHistoryModel(query, page, totalItems);
            return PartialView("~/Views/Company/_companyHistory.cshtml", model);
        }
    }
}

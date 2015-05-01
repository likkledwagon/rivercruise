using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Data.ProxyModel.Ship;
using RiverCruise.Converters.Ship;
using RiverCruise.Helpers;
using RiverCruise.Models.Shared;
using RiverCruise.Models.Ship;
using RiverCruise.Models.ShipManagement;

namespace RiverCruise.Controllers.Manage
{
    public class ShipManagementController : BaseManagementController
    {
        public ActionResult AddShip(int companyId)
        {
            var company = _db.Companies.FirstOrDefault(x => x.Id.Equals(companyId));
            var newShipCompanyViewModel = new NewShipCompanyViewModel();
            if (company == null)
            {
                return RedirectToAction("Index", "Company");
            }
            
            newShipCompanyViewModel.Name = company.Name;
            newShipCompanyViewModel.Id = company.Id;
            

            return View(new NewShipViewModel()
            {
                Comany = newShipCompanyViewModel,
                Since = DateTime.Now
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddShip(NewShipViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dataShip = model.ToNewShipDataModel();

                if (dataShip != null)
                {
                    return View(new NewShipViewModel()
                    {
                        ShipModified = true,
                        Comany = model.Comany
                    });
                }

                ModelState.AddModelError("", "Something went wrong");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult DeleteGet(int id, string name)
        {
            var modalModel = new ModalModel()
            {
                Action = "Delete",
                Arguments = new Dictionary<string, object>() { { "id", id } },
                Body = "Are you sure you want to delete " + name + "?",
                Controller = "ShipManagement",
                Title = "Confirm"
            };

            return PartialView("Modal", modalModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _db.DeleteShip(id);
            }
            catch (Exception)
            {
                return RedirectToAction("Detail", "Home", new {Id = id, actionFailed = true});
            }

            return RedirectToAction("Index", "Home", new { shipDeleted = true });
        }

        public ActionResult Edit(int id, bool shipEdited = false)
        {
            var queryResult = _db.Ships.Find(id);
            if (queryResult == null)
            {
                return HttpNotFound();
            }

            return View(new EditShipViewModel(queryResult, shipEdited));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditShipViewModel model)
        {
            if(ModelState.IsValid)
            { 
                var dataShip = model.ToEditShipDataModel();
                try
                {
                    _db.EditShipData(dataShip);
                    return RedirectToAction("Edit", new { model.Id, shipEdited = true });
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Something went wrong, please try again.");
                }
            }
            return View(model);
        }

        public ActionResult ChangeCompany(int id)
        {
            var ship = _db.Ships.Find(id);

            if (ship == null)
            {
                return HttpNotFound();
            }

            var currentCompany = ship.Ship2Company.Single(x => x.From < DateTime.Now && x.Until >= DateTime.Now);
            var companyOptions = _db.Companies.OrderBy(x => x.Name).Take(10);
            return View(new ChangeCompanymodel(id, currentCompany, companyOptions));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeCompany(ChangeCompanymodel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _db.ChangeCompay(model.ToChangeCompanyProxyModel());
                    model.CompanyChanged = true;
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return View(model);
        }

        [HttpGet]
        public JsonResult AutoComplete(string term)
        {
            var model = _db.Companies.
                Where(r => r.Name.StartsWith(term))
                .OrderBy(o => o.Name)
                .Take(10)
                .Select(r => new {label = r.Name});

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddReport(int id)
        {
            return View("AddReport", new AddReportViewModel(id));
        }

        [HttpPost]
        public ActionResult AddReport(AddReportViewModel report)
        {
            if(ModelState.IsValid)
            { 
                if (report != null && report.File!= null && report.File.ContentLength > 0)
                {
                    var addreportProxyModel = AddReportHelper.CreatetProxyModel(report);

                    try
                    {
                        _db.AddReport(addreportProxyModel);
                        return RedirectToAction("Detail", "Home", new {report.Id});
                    }
                    catch (Exception)
                    {
                        ModelState.AddModelError("File", "Something went wrong uploading while trying to add the report, please try again.");
                    }
                }
            }
            
            return View("AddReport", report);
        }

        public ActionResult RemoveReportGet(int id, int shipId)
        {
            var modalModel = new ModalModel()
            {
                Action = "RemoveReport",
                Arguments = new Dictionary<string, object>() { { "id", id }, {"shipId", shipId} },
                Body = "Are you sure you want to delete this report?",
                Controller = "ShipManagement",
                Title = "Confirm"
            };

            return PartialView("Modal", modalModel);
        }

        [HttpPost]
        public ActionResult RemoveReport(int id, int shipId)
        {
            try
            {
                _db.RemoveReport(id);
                return RedirectToAction("Detail", "Home", new { Id = shipId });
            }
            catch (Exception)
            {
                return RedirectToAction("Detail", "Home", new { Id = shipId });
            }
        }
    }
}
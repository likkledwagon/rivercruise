using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using RiverCruise.Converters.Ship;
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
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Something went wrong, please try again.");
                }
            }
            return View(model);
        }
    }
}
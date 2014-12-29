using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using RiverCruise.Converters;
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
                Comany = newShipCompanyViewModel
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddShip(NewShipViewModel model)
        {
            var dataShip = model.ToShipDataModel();
            
            if(dataShip == null)
            { 
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }

            return View(new NewShipViewModel()
            {
                ShipAdded = true,
                Comany = model.Comany
            });
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

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int id)
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
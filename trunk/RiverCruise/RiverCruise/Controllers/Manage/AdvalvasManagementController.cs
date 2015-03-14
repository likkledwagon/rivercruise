using System;
using System.Collections.Generic;
using System.Web.Mvc;
using RiverCruise.Models.Advalvas;
using RiverCruise.Models.Shared;

namespace RiverCruise.Controllers.Manage
{
    public class AdvalvasManagementController : BaseManagementController
    {
        public ActionResult Add()
        {
            return View(new AddAdvalvasModel());
        }

        [HttpPost]
        public ActionResult Add(AddAdvalvasModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                _db.AddAdvalvas(model.ToDataModel());
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong, please try again");
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult DeleteGet(int id)
        {
            if (Request.IsAjaxRequest())
            {
                var modalModel = new ModalModel()
                {
                    Action = "Delete",
                    Arguments = new Dictionary<string, object>() { { "Id", id } },
                    Body = "Are you sure you want to delete this item ?",
                    Controller = "AdvalvasManagement",
                    Title = "Confirm"
                };

                return PartialView("Modal", modalModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _db.RemoveAdvalvas(id);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
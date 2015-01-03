using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Data.ProxyModel.Company;
using RiverCruise.Converters.Company;
using RiverCruise.Models.CompanyManagement;
using RiverCruise.Models.Shared;

namespace RiverCruise.Controllers.Manage
{
    public class CompanyManagementController : BaseManagementController
    {
        public ActionResult Edit(int id, bool companyEdited = false)
        {
            var company = _db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }

            return View(new EditCompanyModel(company, companyEdited));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditCompanyModel model)
        {
            var proxyModel = model.ToEditCompanyProxyModel();
            try
            {
                _db.EditCompanyData(proxyModel);
                return RedirectToAction("Edit", new { model.Id, companyEdited = true });
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong, please try again.");
                return View(model);
            }

        }

        public ActionResult NewCompany()
        {
            return View(new NewCompanyModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewCompany(NewCompanyModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_db.Companies.Any(x => x.Name == model.Name))
                    {
                        ModelState.AddModelError("", "A company by that name allready exists.");
                    }

                    if(ModelState.IsValid)
                    { 
                        var proxyModel = model.ToNewCompanyProxyModel();

                        _db.AddCompany(proxyModel);

                        model.CompanyAdded = true;
                    }
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Something went wrong please try again.");
                }
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
                Body = "Are you sure you want to delete " + name + " and all it's ships?",
                Controller = "CompanyManagement",
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
                var deleteCompanyProxyModel = new DeleteCompanyProxyModel()
                {
                    Id = id
                };

                _db.DeleteCompany(deleteCompanyProxyModel);

                return RedirectToAction("Index", "Company", new { companyDeleted = true });
            }
            catch (Exception)
            {
                return RedirectToAction("Detail", "Company", new { id = id, actionFailed = true });
            }

            
        }
    }
}
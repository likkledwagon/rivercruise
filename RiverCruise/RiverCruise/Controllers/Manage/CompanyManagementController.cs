using System;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using RiverCruise.Converters.Company;
using RiverCruise.Models.CompanyManagement;

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
            catch (Exception e)
            {
                ModelState.AddModelError("", "Something went wrong, please try again.");
                return View(model);
            }

        }
    }
}
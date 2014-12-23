using System.Linq;
using System.Web.Mvc;
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
    }
}
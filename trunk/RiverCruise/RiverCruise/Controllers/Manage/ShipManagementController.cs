using System.Linq;
using System.Web.Mvc;
using RiverCruise.Converters;
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
            ModelState.AddModelError("", "Under construction");

            //var dataShip = model.ToShipDataModel();
            
            //if(dataShip == null)
            //{ 
            //    ModelState.AddModelError("", "Something went wrong");
            //    return View(model);
            //}

            //_db.Ships.Add(dataShip);
            //_db.SaveChanges();

            return View(new NewShipViewModel()
            {
                ShipAdded = true,
                Comany = model.Comany
            });
        }
    }
}
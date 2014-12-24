using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using RiverCruise.Helpers;
using RiverCruise.Models.Shared;
using RiverCruise.Models.UserManagement;
using WebMatrix.WebData;

namespace RiverCruise.Controllers.Manage
{
    [Authorize(Roles = "Edit")]
    public class UserManagementController : BaseController
    {
        public ActionResult Index(int page = 0, string error = "")
        {
            if (!string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            string[] editusers = Roles.GetUsersInRole(RoleHelper.Edit);
            IEnumerable<dynamic> users = _db.GetUsers;

            return View(new UsersViewModel(users, editusers));
        }

        public ActionResult Add()
        {
            var model = new AddUserViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AddUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Password != model.PasswordConfirm)
            {
                ModelState.AddModelError("Password", "Passwords don't match");
                return View(model);
            }

            if (WebSecurity.UserExists(model.Name))
            {
                ModelState.AddModelError("Name", "A user by that name allready exists");
                return View(model);
            }

            WebSecurity.CreateUserAndAccount(model.Name, model.Password);
            if (model.CanEdit)
            {
                Roles.AddUserToRole(model.Name, RoleHelper.Edit);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteGet(string userName)
        {
            if (Request.IsAjaxRequest())
            {
                var modalModel = new ModalModel()
                {
                    Action = "Delete",
                    Arguments = new Dictionary<string, object>() {{"userName", userName}},
                    Body = "Are you sure you want to delete " + userName + "?",
                    Controller = "UserManagement",
                    Title = "Confirm"
                };

                return PartialView("Modal", modalModel);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string userName = "")
        {
            if (WebSecurity.IsCurrentUser(userName))
            {
                return RedirectToAction("Index", new {error = "Cannot delete own user"});
            }

            if (string.IsNullOrEmpty(userName) || !WebSecurity.UserExists(userName))
            { 
                return RedirectToAction("Index");
            }

            string[] allRoles = Roles.GetRolesForUser(userName);
            if(allRoles.Any())
            { 
                Roles.RemoveUserFromRoles(userName, allRoles);
            }

            ((SimpleMembershipProvider)Membership.Provider).DeleteAccount(userName);
            Membership.Provider.DeleteUser(userName, true);
            Membership.DeleteUser(userName, true);

            return RedirectToAction("Index");
        }
    }
}
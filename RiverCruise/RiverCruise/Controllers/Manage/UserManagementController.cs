using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using RiverCruise.Helpers;
using RiverCruise.Models.UserManagement;
using WebMatrix.WebData;

namespace RiverCruise.Controllers.Manage
{
    [Authorize(Roles = "Edit")]
    public class UserManagementController : BaseController
    {
        public ActionResult Index(int page = 0)
        {
            IEnumerable<dynamic> users;
            string[] editusers = Roles.GetUsersInRole(RoleHelper.Edit);
            using (var db = WebMatrix.Data.Database.Open("DefaultConnection"))
            {
                users = db.Query("SELECT * FROM UserProfile");
            }
            return View(new UsersViewModel(users, editusers));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using RiverCruise.Helpers;
using WebMatrix.WebData;

namespace RiverCruise.Models.UserManagement
{
    public class UsersViewModel
    {
        public UsersViewModel(IEnumerable<object> users, IEnumerable<string> editusers)
        {
            IList<dynamic> usersList = users as IList<dynamic> ?? users.ToList();

            var editUsersList = editusers.ToList();

            Users = new List<UserViewModel>();
            foreach (dynamic o in usersList)
            {
                Users.Add(new UserViewModel()
                {
                    UserId = o["UserId"],
                    UserName = o["UserName"],
                    CanEdit = editUsersList.Contains(o["UserName"])
                });
            }
        }

        public List<UserViewModel> Users { get; set; }
    }
}
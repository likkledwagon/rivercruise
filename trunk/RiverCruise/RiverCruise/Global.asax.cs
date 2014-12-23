﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using RiverCruise.Helpers;
using WebMatrix.WebData;

namespace RiverCruise
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            if (!WebSecurity.UserExists("LikkleDwagon"))
            {
                WebSecurity.CreateUserAndAccount("LikkleDwagon", "Feestje4en!");
            }
            if (!Roles.RoleExists(RoleHelper.Edit))
            {
                Roles.CreateRole(RoleHelper.Edit);
            }

            if (!Roles.GetRolesForUser("LikkleDwagon").Contains(RoleHelper.Edit))
            {
                Roles.AddUserToRole("LikkleDwagon", RoleHelper.Edit);
            }

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
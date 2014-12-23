﻿using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using System.Web.Security;
using Helpers;
using RiverCruise.Models.Account;
using WebMatrix.WebData;

namespace RiverCruise.Controllers
{
    [AllowAnonymous]
    public class AccountController:BaseController
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(User model)
        {
            
            var returnUrl = model.Returnurl;
            if (!WebSecurity.Login(model.UserName, model.Password))
            {
                ModelState.AddModelError("", "The user name or password provided is incorrect.");
                return View(model);
            }
            if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home");
            

            /*
            string encrypt = Encryption.Encrypt(model.Password);
            bool userValid =
                _db.UserProfiles.Any(x => x.UserName.Equals(model.UserName) && x.Password.Equals(encrypt));

            var returnUrl = model.Returnurl;

            if (userValid)
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            */
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }
    }
}
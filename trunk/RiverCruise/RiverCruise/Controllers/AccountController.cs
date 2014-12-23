using System;
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
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new User()
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(User model, string returnUrl)
        {
            if (string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password))
            {
                if (string.IsNullOrEmpty(model.UserName))
                { 
                    ModelState.AddModelError("UserName", "User name cannot be empty");
                }
                if (string.IsNullOrEmpty(model.Password))
                {
                    ModelState.AddModelError("PassWord", "Password cannot be empty");
                }

                return View(model);
            }

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
            
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }
    }
}
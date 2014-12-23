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
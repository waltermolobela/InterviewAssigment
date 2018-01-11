using InterviewAssigmentSolution.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace InterviewAssigmentSolution.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// POST: /Account/Login
        /// </summary>
        /// <param name="model">Login View Model used to verify that the login is correct</param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Login()
        {
            // before going to the next view, store the return url (if any)
            if (!string.IsNullOrWhiteSpace(Request.QueryString["ReturnUrl"]))
                TempData["ReturnUrl"] = Request.QueryString["ReturnUrl"];

            return View();
        }

        /// <summary>
        /// POST: /Account/Login
        /// </summary>
        /// <param name="model">Login View Model used to verify that the login is correct</param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            
            ModelState.AddModelError("", model.ErrorMessage);
            return View(model);
           
        }

        /// <summary>
        /// POST: /Account/LogOff
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
    }
}
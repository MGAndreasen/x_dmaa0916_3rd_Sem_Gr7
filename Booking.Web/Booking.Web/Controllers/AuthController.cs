using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Booking.Web.Models;
using Booking.Web.Helpers;
using Booking.Web.BookingAuthRemote;

namespace Booking.Web.Controllers
{
    public class AuthController : Controller
    {
  
        // GET: AuthController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel lvm)
        {
             //canLogIn = false;
            BookingAuthRemote.User hmm;

            using (var authsvc = ServiceHelper.GetAuthServiceClient())
            {
                hmm = authsvc.Login(lvm.Email, lvm.Password);
            }

            if (hmm == null)
            {
                ViewBag.StatusMessage = "Could not login with the given credentials";
                return View();
            }
            else
            {
                lvm.Email = hmm.Email;
                lvm.Password = hmm.Password;

                if (hmm.Roles.First().Name.ToString().ToLower() == "admin")
                {
                    lvm.UserType = "Admin";
                }
                else
                {
                    lvm.UserType = "User";
                }
                
                AuthHelper.Login(lvm);
                return RedirectToAction("MembersOnly");
            }
        }

        public ActionResult Logout()
        {

            AuthHelper.Logout();
            return RedirectToAction("Index","Home");


        }
        public ActionResult MembersOnly()
        {
            return View();
        }
    }
}
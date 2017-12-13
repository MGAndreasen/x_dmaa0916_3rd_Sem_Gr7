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

        public static IEnumerable<ZipCodesViewModel> ZipCodes = new List<ZipCodesViewModel> {
    new ZipCodesViewModel {
        ZipCode = 9000,
        CityName = "Aalborg"
    },
    new ZipCodesViewModel {
        ZipCode = 9800,
        CityName = "Hjoerring"
    }
};
        // GET: AuthController
        public ActionResult Index()
        {
            ViewBag.ZipCodes = ZipCodes;

            try
            {
                ViewBag.proxy = (BookingServiceRemote.ServiceClient)ServiceHelper.GetServiceClientWithCredentials();
                ViewBag.proxyError = "";
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(NewUserViewModel NewUser)
        {
            ViewBag.ZipCodes = ZipCodes;

            ViewBag.Test = NewUser.FirstName;

            try
            {
                ViewBag.proxy = (BookingServiceRemote.ServiceClient)ServiceHelper.GetServiceClientWithCredentials();
                ViewBag.proxyError = "";
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

            return View();
        }

        public ActionResult Login()
        {
            try
            {
                ViewBag.proxy = (BookingServiceRemote.ServiceClient)ServiceHelper.GetServiceClientWithCredentials();
                ViewBag.proxyError = "";
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

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
                else if (hmm.Roles.First().Name.ToString().ToLower() == "user")
                {
                    lvm.UserType = "User";
                }
                else
                {
                    lvm.UserType = "Guest";
                }

                AuthHelper.Login(lvm);
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {

            AuthHelper.Logout();
            return RedirectToAction("Index", "Home");


        }
        public ActionResult MembersOnly()
        {
            try
            {
                ViewBag.proxy = (BookingServiceRemote.ServiceClient)ServiceHelper.GetServiceClientWithCredentials();
                ViewBag.proxyError = "";
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

            return View();
        }
    }
}
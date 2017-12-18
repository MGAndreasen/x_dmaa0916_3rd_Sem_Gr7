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

        public ActionResult Index()
        {
            return RedirectToAction("SignUp", "Auth");
        }

        // GET: AuthController
        public ActionResult SignUp()
        {
            NewUserViewModel NewUser = new NewUserViewModel();
            List<ZipCodesViewModel> AllCitys = new List<ZipCodesViewModel>();
            BookingServiceRemote.ServiceClient client = null;

            try
            {
                client = ServiceHelper.GetServiceClient();
                ViewBag.proxyError = "";
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

            if (client != null)
            {
                ViewBag.proxy = client;
                var CityResult = client.GetAllCitys();

                foreach (var c in CityResult)
                {
                    AllCitys.Add(new ZipCodesViewModel { ZipCode = c.Zipcode, CityName = c.CityName });
                }

                NewUser.ZipCodes = AllCitys;
            }

            return View(NewUser);
        }

        [HttpPost]
        public ActionResult SignUp(NewUserViewModel NewUser)
        {
            bool lykkes = false;

            ViewBag.Test = NewUser.FirstName;
            List<ZipCodesViewModel> AllCitys = new List<ZipCodesViewModel>();
            AuthClient ac = null;
            BookingServiceRemote.ServiceClient client = null;

            try
            {
                client = ServiceHelper.GetServiceClient();
                ac = ServiceHelper.GetAuthClient();
            }
            catch (Exception ex)
            {
                ViewBag.proxyError = ex.ToString();
            }

            if (client != null || ac != null)
            {
                LoginViewModel lvm = new LoginViewModel();

                ViewBag.proxy = client;


                var CityResult = client.GetAllCitys();

                foreach (var c in CityResult)
                {
                    AllCitys.Add(new ZipCodesViewModel { ZipCode = c.Zipcode, CityName = c.CityName });
                }

                NewUser.ZipCodes = AllCitys;


                //if (NewUser.Email.Length >= 6 && NewUser.Password.Length >= 4 && NewUser.FirstName.Length >= 2 && NewUser.LastName.Length >= 2 && NewUser.Address.Length >= 4 && NewUser.ZipCode > 999 && NewUser.PhoneNumber > 0 && NewUser.Password == NewUser.Password2)
                if (ModelState.IsValid && NewUser.Password == NewUser.Password2)
                {

                    NewUser.Email = NewUser.Email.ToString().Trim().ToLower();
                    NewUser.Password = NewUser.Password.Trim();
                    NewUser.FirstName = NewUser.FirstName.Trim();
                    NewUser.LastName = NewUser.LastName.Trim();
                    NewUser.Address = NewUser.Address.Trim();
                    NewUser.Password2 = NewUser.Password2.Trim();

                    lykkes = ac.CreateLogin(NewUser.Email, NewUser.Password, NewUser.FirstName, NewUser.LastName, NewUser.Address, NewUser.ZipCode, NewUser.PhoneNumber);

                    BookingAuthRemote.User hmm;
                    if (lykkes)
                    {
                        lvm.Email = NewUser.Email;
                        lvm.Password = NewUser.Password;

                        hmm = ac.Login(lvm.Email, lvm.Password);

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
                    }
                }
                else
                {
                    ViewBag.StatusMessage = "Formen er ikke udfyldt korrekt.";
                }

                if (lykkes)
                {
                    return RedirectToAction("MembersOnly", "Auth");
                }
                else
                {
                    return View(NewUser);
                }
            }
            else
            {
                return View(NewUser);
            }


        }

        public ActionResult Login()
        {
            try
            {
                ViewBag.proxy = (BookingServiceRemote.ServiceClient)ServiceHelper.GetServiceClient();
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

            using (var authsvc = ServiceHelper.GetAuthClient())
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
                lvm.Id = hmm.Id;
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
                ViewBag.proxy = (BookingServiceRemote.ServiceClient)ServiceHelper.GetServiceClient();
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
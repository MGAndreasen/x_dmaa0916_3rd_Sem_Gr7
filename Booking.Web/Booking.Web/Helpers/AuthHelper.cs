using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Booking.Web.Models;

namespace Booking.Web.Helpers
{
    public class AuthHelper
    {
        private static string LoginSessionName = "LoggedInUser";

        private static LoginViewModel currentUser;

        public static LoginViewModel CurrentUser
        {
            get
            {
                return HttpContext.Current.Session[LoginSessionName] as LoginViewModel;
            }
            set
            {
                currentUser = value;
            }
        }

        public static bool IsLoggedIn()
        {
            if(HttpContext.Current.Session[LoginSessionName] != null)
            {
                if (((LoginViewModel)HttpContext.Current.Session[LoginSessionName]).Email != "guest")
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsAdmin()
        {
            return ((LoginViewModel)HttpContext.Current.Session[LoginSessionName]).UserType.ToString().ToLower() == "admin";
        }

        public static void Login(LoginViewModel lvm)
        {
            HttpContext.Current.Session[LoginSessionName] = lvm;
        }

        public static void Logout()
        {
            HttpContext.Current.Session[LoginSessionName] = null;
        }

    }
}
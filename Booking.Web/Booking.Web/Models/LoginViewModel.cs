using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking.Web.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
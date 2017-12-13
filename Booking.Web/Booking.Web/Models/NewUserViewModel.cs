using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking.Web.Models
{
    public class NewUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public ZipCodesViewModel ZipCode { get; set; }
    }
}
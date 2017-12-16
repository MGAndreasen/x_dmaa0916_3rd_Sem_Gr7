using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Booking.Web.Models
{
    public class NewUserViewModel
    {
        [Required(ErrorMessage = "* Required!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "* Required!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "* Required!")]
        [Compare("Password", ErrorMessage = "Password doesn't match!")]
        public string Password2 { get; set; }

        [Required(ErrorMessage = "* Required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* Required!")]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "* Required!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "* Required!")]
        [Range(999, 9999)]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "* Required!")]
        [Display(Name = "CityName")]
        public IEnumerable<ZipCodesViewModel> ZipCodes { get; set; }

        public NewUserViewModel()
        {
            ZipCodes = new List<ZipCodesViewModel>();
        }
    }
}
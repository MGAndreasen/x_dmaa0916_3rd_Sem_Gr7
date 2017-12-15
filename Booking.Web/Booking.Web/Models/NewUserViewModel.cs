using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Booking.Web.Models
{
    public class NewUserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password2 { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public long PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Range(999, 9999)]
        public int ZipCode { get; set; }

        [Required]
        [Display(Name = "CityName")]
        public IEnumerable<ZipCodesViewModel> ZipCodes { get; set; }

        public NewUserViewModel()
        {
            ZipCodes = new List<ZipCodesViewModel>();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public City City { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long CPR { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool Confirmed { get; set; }

    }
}

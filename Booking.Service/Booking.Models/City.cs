using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class City
    {
        public int Zipcode { get; set; }
        public string CityName { get; set; }

        // Constructors
        public City(int zipcode, string name)
        {
            Zipcode = zipcode;
            CityName = name;
        }

        public City()
        {
        }
    }
}

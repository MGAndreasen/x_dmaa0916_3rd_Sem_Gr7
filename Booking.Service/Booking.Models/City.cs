using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    [DataContract]
    public class City
    {
        // Constructors

        public City()
        {
        }

        public City(int zipcode, string name)
        {
            Zipcode = zipcode;
            CityName = name;
        }

        // Properties

        [DataMember]
        public int Zipcode { get; set; }

        [DataMember]
        public string CityName { get; set; }

        
        public override string ToString()
        {
            return Zipcode.ToString() + " " + CityName.ToString() + " ";
        }
    }
}

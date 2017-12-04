using System.Runtime.Serialization;

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

    }
}
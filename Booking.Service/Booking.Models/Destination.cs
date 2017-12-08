using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class Destination
    {
        //Ctors
        public Destination()
        {
        }

        //Properties
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Plane Plane { get; set; }

        [DataMember]
        public string NameDestination { get; set; }

    }
}
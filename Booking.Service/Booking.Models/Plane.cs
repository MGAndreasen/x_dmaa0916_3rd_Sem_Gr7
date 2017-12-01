using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class Plane
    {

        //Ctors
        public Plane()
        {
        }

        //Properties
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public SeatSchema SeatSchema { get; set; }

    }
}

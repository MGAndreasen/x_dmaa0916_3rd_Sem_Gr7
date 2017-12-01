using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class Seat
    {
        // Constructors
        public Seat()
        {
        }


        // Properties

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public bool Available { get; set; }

        [DataMember]
        public Row Row { get; set; }
    }
}

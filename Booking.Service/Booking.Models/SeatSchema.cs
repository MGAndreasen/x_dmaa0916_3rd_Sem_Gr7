using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class SeatSchema
    {
        public SeatSchema()
        {
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Row { get; set; }

        [DataMember]
        public int Layout { get; set; }
    }
}

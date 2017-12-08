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

        // Burde vi fjerne, da vi faktisk godt ved hvilket plane et schea høre til, hvis der holdes styr på plane_seatschema listen
        [DataMember]
        public int PlaneId { get; set; }

        [DataMember]
        public int Row { get; set; }

        [DataMember]
        public string Layout { get; set; }
    }
}

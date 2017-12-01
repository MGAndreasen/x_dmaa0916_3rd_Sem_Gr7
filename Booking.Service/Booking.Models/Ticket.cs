using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class Ticket
    {
        // Constructors

        public Ticket()
        {
        }

        public Ticket(int id, Passenger p)
        {
            Id = id;
            Passenger = p;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Passenger Passenger { get; set; }
    }
}

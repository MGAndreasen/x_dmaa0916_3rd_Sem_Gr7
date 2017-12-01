using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class Passenger
    {
        //Ctors
        public Passenger()
        {
        }

        //Properties
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public long CPR { get; set; }
        [DataMember]
        public long PassportId { get; set; }
        [DataMember]
        public bool Luggage { get; set; }
        [DataMember]
        public Seat SeatNumber { get; set; }
        [DataMember]
        public Bookings Booking { get; set; }

    }
}

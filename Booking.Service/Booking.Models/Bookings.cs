using System;
using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class Bookings
    {
        // Constructors

        public Bookings()
        {
        }

        // Properties

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Payment Payment { get; set; }

        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public Departure Departure { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public int TotalPrice { get; set; }
    }
}

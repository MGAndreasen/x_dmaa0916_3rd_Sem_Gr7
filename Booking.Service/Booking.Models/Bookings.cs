using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
        public Destination StartDestination { get; set; }

        [DataMember]
        public Destination EndDestination { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public int TotalPrice { get; set; }
    }
}

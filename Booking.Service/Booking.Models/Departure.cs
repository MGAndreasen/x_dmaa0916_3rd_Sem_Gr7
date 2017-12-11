using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    [DataContract]
    public class Departure
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Destination StartDestination { get; set; }

        [DataMember]
        public Destination EndDestination { get; set; }

        [DataMember]
        public DateTime DepartureTime { get; set; }

        [DataMember]
        public Plane Plane { get; set; }

        public Departure()
        {
            //Constructor xD
        }
    }
}

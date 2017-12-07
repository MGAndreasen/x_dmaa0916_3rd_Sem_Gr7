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
        public string StartDestination { get; set; }
        [DataMember]
        public string EndDestination { get; set; }
        [DataMember]
        public DateTime DepartureTime { get; set; }
        [DataMember]
        public Plane PlaneId { get; set; }

        public Departure()
        {
            //Constructure
        }
    }
}

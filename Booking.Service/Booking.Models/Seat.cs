using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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

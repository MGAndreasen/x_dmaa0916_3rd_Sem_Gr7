using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    [DataContract]
    public class Row
    {
        //Ctors
        public Row()
        {
        }

        //Properties
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public SeatSchema SeatNumber { get; set; }
        [DataMember]
        public double Price { get; set; }

    }
}

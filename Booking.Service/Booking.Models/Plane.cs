using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    [DataContract]
    public class Plane
    {

        //Ctors
        public Plane()
        {
        }

        //Properties
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public SeatSchema SeatSchema { get; set; }

        public override string ToString()
        {
            return Type.ToString() + " ";
        }
    }
}

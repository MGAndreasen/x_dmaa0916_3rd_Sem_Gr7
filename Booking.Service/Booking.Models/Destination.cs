using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    [DataContract]
    public class Destination
    {
        //Ctors
        public Destination()
        {
        }

        //Properties
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Plane Plane { get; set; }
        [DataMember]
        public string NameDestination { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    [DataContract]
    public class SeatSchema
    {
        public SeatSchema()
        {
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Row { get; set; }

        [DataMember]
        public string Layout { get; set; }
    }
}

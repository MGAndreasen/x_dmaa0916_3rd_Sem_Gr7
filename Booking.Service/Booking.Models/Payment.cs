using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    [DataContract]
    public class Payment
    {

        //Ctors
        public Payment()
        {
        }

        //Properties
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public double Amount { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

    }
}

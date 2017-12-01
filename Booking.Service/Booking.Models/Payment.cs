using System;
using System.Runtime.Serialization;

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

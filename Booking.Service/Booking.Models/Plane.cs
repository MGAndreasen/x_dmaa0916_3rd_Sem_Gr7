using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Booking.Models
{
    [DataContract]
    public class Plane
    {

        //Ctors
        public Plane()
        {
            SeatSchema = new List<Models.SeatSchema>();
        }

        //Properties
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public List<SeatSchema> SeatSchema { get; set; }

    }
}

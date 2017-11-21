using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Seat
    {
        public bool Availability;

        public int Id { get; set; }
        public int Number { get; set; }
        public bool Available { get; set; }
    }
}

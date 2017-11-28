using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Seat
    {
        public Seat()
        {
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public bool Available { get; set; }
        public Row Row { get; set; }
    }
}

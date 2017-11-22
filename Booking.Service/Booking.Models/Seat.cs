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

        public Seat()
        {
        }

        public Seat(int id, int number, bool available)
        {
            this.Id = id;
            this.Number = number;
            this.Availability = available;
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public bool Available { get; set; }
    }
}

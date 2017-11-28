using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Passenger Passenger { get; set; }

        // Constructors
        public Ticket(int id, Passenger p)
        {
            Id = id;
            Passenger = p;
        }

        public Ticket()
        {
        }
    }
}

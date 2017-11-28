using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Bookings
    {
        public Bookings()
        {
        }

        public int Id { get; set; }
        public Payment Payment { get; set; }
        public Customer Customer { get; set; }
        public Destination StartDestination { get; set; }
        public Destination EndDestination { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
    }
}

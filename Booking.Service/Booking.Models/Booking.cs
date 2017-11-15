using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Destination StartDestination { get; set; }
        public Destination EndDestination { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }


    }
}

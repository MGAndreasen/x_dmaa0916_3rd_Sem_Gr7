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
        public string StartDestination { get; set; }
        public string EndDestination { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }

    }
}

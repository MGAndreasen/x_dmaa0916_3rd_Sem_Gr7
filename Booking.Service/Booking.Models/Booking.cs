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
        public List<Destination> Destinations { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }

    }
}

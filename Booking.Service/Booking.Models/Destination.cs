using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public Plane Plane { get; set; }
        public string NameDestination { get; set; }
    }
}
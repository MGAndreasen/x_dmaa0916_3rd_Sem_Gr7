using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Plane
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Row> Rows { get; set; }
        public List<SeatSchema> SeatSchema { get; set; }
        
    }
}

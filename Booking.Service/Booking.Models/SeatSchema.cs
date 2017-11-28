using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class SeatSchema
    {
        public SeatSchema()
        {
        }

        public int Id { get; set; }
        public int Row { get; set; }
        public string Layout { get; set; }
        
    }
}

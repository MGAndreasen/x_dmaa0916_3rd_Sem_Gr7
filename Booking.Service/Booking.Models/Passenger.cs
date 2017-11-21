using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CPR { get; set; }
        public long PassportId { get; set; }
        public bool Luggage { get; set; }
        public Seat SeatNumber { get; set; }
        
    }
}

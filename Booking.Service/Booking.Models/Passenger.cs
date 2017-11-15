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
        public int CPR { get; set; }
        public int PassportNumber { get; set; }
        public int ExtraLuggage { get; set; }
        public Seat SeatNumber { get; set; }
        
    }
}

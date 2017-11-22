using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Ticket
    {
        public Ticket()
        {
        }

        public Ticket(int id)
        {
            this.Id = Id;
        }

        public int Id { get; set; }
        
    }
}

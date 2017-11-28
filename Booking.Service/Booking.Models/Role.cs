using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class Role
    {
        public Role()
        {
            User = new List<User>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> User { get; set; }
    }
}

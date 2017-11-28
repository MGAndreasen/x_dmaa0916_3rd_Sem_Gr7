using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class UserController
    {
        private DbUser dbUser;

        public UserController()
        {
            dbUser = new DbUser();
        }
        public User GetUser(int id)
        {
            return dbUser.Get(id);
        }
        public User GetUser(string email)
        {
            return dbUser.Get(email);
        }
    }
}

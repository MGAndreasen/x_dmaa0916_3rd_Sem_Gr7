using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class UserCtrl
    {
        private DbUser dbUser;
        private CustomerCtrl cCtrl;

        public UserCtrl()
        {
            dbUser = new DbUser();
            cCtrl = new CustomerCtrl();
        }

        public User GetUser(string email)
        {
            return dbUser.GetUser(email);
        }

        public bool CreateUser(Customer c)
        {
            return cCtrl.Create(c);
        }
    }
}

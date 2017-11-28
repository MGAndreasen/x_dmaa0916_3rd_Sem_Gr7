using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;

namespace Booking.DB
{
    public class DbUser
    {
        public Booking.Models.User Get(int id)
        {
            User u = null;

            if (id == 1)
            {
                List<Role> userRoles = new List<Role> { new Models.Role { Id = 1, Name = "Admin" } };
                u = new Models.User { Id = 1, Email = "admin@test.dk", Password = "1234", Roles = userRoles };
            }
            else if (id == 2)
            {
                List<Role> userRoles = new List<Role> { new Models.Role { Id = 2, Name = "User" } };
                u = new Models.User { Id = 2, Email = "user@test.dk", Password = "1234", Roles = userRoles };
            }
            else
            {
                // Ingen bruger
            }

            return u;
        }

        public Booking.Models.User Get(string email)
        {
            User u = null;

            if (email == "admin@test.dk")
            {
                List<Role> userRoles = new List<Role> { new Role { Id = 1, Name = "Admin" } };
                u =  new User { Id = 1, Email = "admin@test.dk", Password = "1234", Roles = userRoles };
            }
            else if (email == "admin@test.dk")
            {
                List<Role> userRoles = new List<Role> { new Role { Id = 2, Name = "User" } };
                u = new User { Id = 2, Email = "user@test.dk", Password = "1234", Roles = userRoles };
            }
            else
            {
                // Ingen bruger
            }

            return u;
        }
    }
}

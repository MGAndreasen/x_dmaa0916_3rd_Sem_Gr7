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
            id = 1;
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
            else if (id == 3)
            {
                List<Role> userRoles = new List<Role> { new Role { Id = 3, Name = "Guest" } };
                u = new User { Id = 3, Email = "guest", Password = "guest", Roles = userRoles };
            }
            else
            {
                // Ingen bruger
            }

            return u;
        }

        public Booking.Models.User Get(string email)
        {
            //email = "admin@test.dk";

            User u;

            if (email == "admin@test.dk")
            {
                List<Role> userRoles = new List<Role> { new Role { Id = 1, Name = "Admin" } };
                u =  new User { Id = 1, Email = "admin@test.dk", Password = "1234", Roles = userRoles };
            }
            else if (email == "user@test.dk")
            {
                List<Role> userRoles = new List<Role> { new Role { Id = 2, Name = "User" } };
                u = new User { Id = 2, Email = "user@test.dk", Password = "1234", Roles = userRoles };
            }
            else if (email == "guest")
            {
                List<Role> userRoles = new List<Role> { new Role { Id = 3, Name = "Guest" } };
                u = new User { Id = 3, Email = "guest", Password = "guest", Roles = userRoles };
            }
            else
            {
                // Ingen bruger
                u = null;
            }
            //Console.WriteLine("Login: " + (u  != null ? "someone logged in as:" + u.Email.ToString() : "someone tried to login as: " + email + " (but failed!)"));
            return u;
        }
    }
}

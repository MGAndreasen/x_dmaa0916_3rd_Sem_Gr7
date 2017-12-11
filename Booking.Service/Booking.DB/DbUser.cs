using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using System.Data.SqlClient;
using System.Data;

namespace Booking.DB
{
    public class DbUser
    {
        private DataAccess data = DataAccess.Instance;

        //public Booking.Models.User Get(int id)
        //{
        //    id = 1;
        //    User u = null;

        //    if (id == 1)
        //    {
        //        List<Role> userRoles = new List<Role> { new Models.Role { Id = 1, Name = "Admin" } };
        //        u = new Models.User { Id = 1, Email = "admin@test.dk", Password = "1234", Roles = userRoles };
        //    }
        //    else if (id == 2)
        //    {
        //        List<Role> userRoles = new List<Role> { new Models.Role { Id = 2, Name = "User" } };
        //        u = new Models.User { Id = 2, Email = "user@test.dk", Password = "1234", Roles = userRoles };
        //    }
        //    else if (id == 3)
        //    {
        //        List<Role> userRoles = new List<Role> { new Role { Id = 3, Name = "Guest" } };
        //        u = new User { Id = 3, Email = "guest", Password = "guest", Roles = userRoles };
        //    }
        //    else
        //    {
        //        // Ingen bruger
        //    }

        //    return u;
        //}

        public Customer GetUser(string email)
        {
            Customer c = null;
            DbCity dbc = new DbCity();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Customer WHERE Email = @Email", con);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    c = new Customer
                    {
                        Id = (int)rdr["Id"],
                        CPR = (long)rdr["Cpr"],
                        PhoneNumber = (long)rdr["PhoneNo"],
                        City = dbc.Get((int)rdr["City_Id"]),
                        FirstName = (string)rdr["FirstName"],
                        LastName = (string)rdr["LastName"],
                        Email = (string)rdr["Email"],
                        Address = (string)rdr["Address"],
                        Password = (string)rdr["Password"],
                        Confirmed = (bool)rdr["Cofirmed"],
                        Role = (string)rdr["Roles"],
                        LastActive = (DateTime)rdr["LastActive"]
                    };
                }
            }

            if (email == "guest")
            {
               c = new Customer { Email = "guest", Password = "guest", Role = "Guest" };
            }

            return c;

            //else if (email == "guest")
            //{
            //    List<Role> userRoles = new List<Role> { new Role { Id = 3, Name = "Guest" } };
            //    u = new User { Id = 3, Email = "guest", Password = "guest", Roles = userRoles };
            //}

            //Console.WriteLine("Login: " + (u != null ? "someone logged in as:" + u.Email.ToString() : "someone tried to login as: " + email + " (but failed!)"));
        }

        //public Customer GetUser(string email)
        //{
        //    Customer c = null;
        //    DbCity dbc = new DbCity();
        //    using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Customer WHERE Email = @Email", con);
        //        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            c = new Customer
        //            {
        //                Id = (int)rdr["Id"],
        //                CPR = (long)rdr["Cpr"],
        //                PhoneNumber = (long)rdr["PhoneNo"],
        //                City = dbc.Get((int)rdr["City_Id"]),
        //                FirstName = (string)rdr["FirstName"],
        //                LastName = (string)rdr["LastName"],
        //                Email = (string)rdr["Email"],
        //                Address = (string)rdr["Address"],
        //                Password = (string)rdr["Password"],
        //                Confirmed = (bool)rdr["Cofirmed"],
        //                Role = (string)rdr["Roles"],
        //                LastActive = (DateTime)rdr["LastActive"]
        //            };
        //        }
        //        return c;

        //    }
        //}
    }
}

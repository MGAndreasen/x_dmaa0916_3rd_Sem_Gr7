using Booking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Booking.DB.ScopeHelper;

namespace Booking.DB
{
    public class DbCustomer : IDbCRUD<Customer>
    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Booking_Customer WHERE Id=@id", con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }

        public Customer Get(int id)
        {
            DbCity dbc = new DbCity();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT s.Id, s.Cpr, s.PhoneNo, s.City_Id, s.FirstName, s.LastName, s.Email, s.Address, s.Password, s.Comfirmed FROM dbo.Booking_Customer AS s WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader reader = cmd.ExecuteReader();
                return new Customer
                {
                    Id = reader.GetInt32(0),
                    CPR = reader.GetInt32(1),
                    PhoneNumber = reader.GetInt32(2),
                    City = dbc.Get(reader.GetInt32(3)),
                    FirstName = reader.GetString(4),
                    LastName = reader.GetString(5),
                    Email = reader.GetString(6),
                    Address = reader.GetString(7),
                    Password = reader.GetString(8),
                    Confirmed = reader.GetBoolean(9)
                };
            }
        }

        public void Create(Customer obj)
        {

            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Customer (Id, Cpr, PhoneNo, City_Id, FirstName, LastName, Email, Address, Password, Comfirmed) VALUES (@Id, @Cpr, @PhoneNo, @City, @FirstName, @LastName, @Email. @Address, @Password, @Comfirmed)", con);
                    cmd.Parameters.Add("Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("Cpr", SqlDbType.BigInt).Value = obj.CPR;
                    cmd.Parameters.Add("PhoneNo", SqlDbType.BigInt).Value = obj.PhoneNumber;
                    cmd.Parameters.Add("City", SqlDbType.Int).Value = obj.City;
                    cmd.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = obj.FirstName;
                    cmd.Parameters.Add("LastName", SqlDbType.NVarChar).Value = obj.LastName;
                    cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = obj.Email;
                    cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = obj.Address;
                    cmd.Parameters.Add("Password", SqlDbType.NVarChar).Value = obj.Password;
                    cmd.Parameters.Add("Comfirmed", SqlDbType.Bit).Value = obj.Confirmed;

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }

        }


        public void Update(Customer obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Customer SET Cpr=@cpr, PhoneNo=@pho, City_Id=@city, FirstName=@fn, LastName=@ln, Email=@em, Address=@a, Password=@p, Confirmed=@con WHERE ID=@id", con);
                    cmd.Parameters.AddWithValue("id", obj.Id);
                    cmd.Parameters.AddWithValue("cpr", obj.CPR);
                    cmd.Parameters.AddWithValue("pho", obj.PhoneNumber);
                    cmd.Parameters.AddWithValue("city", obj.City);
                    cmd.Parameters.AddWithValue("fn", obj.FirstName);
                    cmd.Parameters.AddWithValue("ln", obj.LastName);
                    cmd.Parameters.AddWithValue("em", obj.Email);
                    cmd.Parameters.AddWithValue("a", obj.Address);
                    cmd.Parameters.AddWithValue("p", obj.Password);
                    cmd.Parameters.AddWithValue("con", obj.Confirmed);

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            DbCity dbCity = new DbCity();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Customer";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        customers.Add(new Customer
                        {
                            Id = (int)rdr["Id"],
                            FirstName = (string)rdr["FirstName"],
                            LastName = (string)rdr["LastName"],
                            Email = (string)rdr[""],
                            CPR = (long)rdr["Cpr"],
                            PhoneNumber = (long)rdr["PhoneNo"],
                            City = dbCity.Get((int)rdr["ZipCode"]),
                            Address = (string)rdr["Address"],
                            Password = (string)rdr["Password"]

                        });
                    }
                }

            }
            return customers;
        }
    }
}

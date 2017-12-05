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
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Customer WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                Customer customer = new Customer
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
                    Confirmed = (bool)rdr["Cofirmed"]
                };
                return customer;
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Customer (Id, Cpr, PhoneNo, City_Id, FirstName, LastName, Email, Address, Password, Cofirmed) VALUES (@Id, @Cpr, @PhoneNo, @City, @FirstName, @LastName, @Email. @Address, @Password, @Cofirmed)", con);
                    cmd.Parameters.Add("Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("Cpr", SqlDbType.BigInt).Value = obj.CPR;
                    cmd.Parameters.Add("PhoneNo", SqlDbType.BigInt).Value = obj.PhoneNumber;
                    cmd.Parameters.Add("City", SqlDbType.Int).Value = obj.City;
                    cmd.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = obj.FirstName;
                    cmd.Parameters.Add("LastName", SqlDbType.NVarChar).Value = obj.LastName;
                    cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = obj.Email;
                    cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = obj.Address;
                    cmd.Parameters.Add("Password", SqlDbType.NVarChar).Value = obj.Password;
                    cmd.Parameters.Add("Cofirmed", SqlDbType.Bit).Value = obj.Confirmed;

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
                    con.Open();
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
            DbPayment dbp = new DbPayment();
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
                            Password = (string)rdr["Password"],
                            Confirmed = (bool)rdr["Cofirmed"],
                        });
                    }
                }

            }
            return customers;
        }

        public int CountOnline()
        {
            int num = 0;
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT count(*) as num FROM Booking_Customer WHERE DATEADD(SECOND,-30,LastActive) <= GETDATE()", con);
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    rdr.Read();
                    num = (int)rdr["num"];
                }
            }

            return num;
        }

        public void UpdActivity(int id)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Booking_Customer SET LastActive=getdate() WHERE ID=@id", con);
                    cmd.Parameters.AddWithValue("ID", id);

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }
    }
}

using Booking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Booking.DB
{
    public class DbCustomer : IDbCRUD<Customer>
    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };
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
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT s.Id, s.Cpr, s.PhoneNo, s.Zipcode, s.FirstName, s.LastName, s.Email, s.Address, s.Password, s.Comfirmed FROM dbo.Booking_Customer AS s WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader reader = cmd.ExecuteReader();
                return new Customer
                {
                    Id = reader.GetInt32(0),
                    CPR = reader.GetInt32(1),
                    PhoneNumber = reader.GetInt32(2),
                    //zipcode
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

            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Customer (Id, Cpr, PhoneNo, Zipcode, FirstName, LastName, Email, Address, Password, Comfirmed) VALUES (@Id, @Cpr, @PhoneNo, @Zipcode, @FirstName, @LastName, @Email. @Address, @Password, @Comfirmed)", con);
                    cmd.Parameters.Add("Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("Cpr", SqlDbType.BigInt).Value = obj.CPR;
                    cmd.Parameters.Add("PhoneNo", SqlDbType.BigInt).Value = obj.PhoneNumber;
                    cmd.Parameters.Add("Zipcode", SqlDbType.SmallInt).Value = obj.City;
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
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Customer SET Cpr=@cpr, PhoneNo=@pho, Zipcode=@city, FirstName=@fn, LastName=@ln, Email=@em, Address=@a, Password=@p, Confirmed=@con WHERE ID=@id", con);
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
    }
}

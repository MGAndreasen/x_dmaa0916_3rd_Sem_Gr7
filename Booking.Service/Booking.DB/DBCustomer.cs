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
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Customer obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Customer (@Id, @Cpr, @PhoneNo, @Zipcode, @FirstName, @LastName, @Email. @Address, @Password, @Comfirmed)", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Cpr", SqlDbType.BigInt).Value = obj.CPR;
                    cmd.Parameters.Add("@PhoneNo", SqlDbType.BigInt).Value = obj.PhoneNumber;
                    cmd.Parameters.Add("@Zipcode", SqlDbType.SmallInt).Value = obj.City;
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = obj.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = obj.LastName;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = obj.Address;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = obj.Password;
                    cmd.Parameters.Add("@Comfirmed", SqlDbType.Bit).Value = obj.Confirmed;

                    cmd.ExecuteNonQuery();

                    scope.Complete();

                }
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class DbPayment : IDbCRUD<Payment>
    {
        private DataAccess data = DataAccess.Instance;

 

        public Payment Get(int id)
        {
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT FROM dbo.Booking_Payment WHERE Id = @id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    SqlDataReader rdr = cmd.ExecuteReader();
                        return new Payment
                        {
                            Id = rdr.GetInt32(0),
                            Amount = rdr.GetInt32(1),
                            Date = rdr.GetDateTime(2)
                        };
                }
        }

        public void Create(Payment obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Payment (@id, @Amount, @Date", con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = obj.Amount;
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
                    cmd.ExecuteNonQuery();
                    {
                        //tilføj til model.
                    }
                }
            }
        }

        public void Update(Payment obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Payment SET Id=@Id, Amount=@AM, Date=@DT", con);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@AM", SqlDbType.Int).Value = obj.Amount;
                    cmd.Parameters.Add("@DT", SqlDbType.DateTime).Value = obj.Date;
                    

                    cmd.ExecuteNonQuery();
                    scope.Complete();
                }
            }
        }
        public IEnumerable<Payment> GetAll()
        {
            List<Payment> payments = new List<Payment>();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM bdo.Booking_Passenger";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Payment p = new Payment
                        {
                            Id = (int)rdr["Id"],
                            Amount = (int)rdr["Amount"],
                            Date = (DateTime)rdr["Date"],                  
                        };
                        payments.Add(p);
                    }
                }

            }
            return payments;
        }
        public void Delete(int id)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();

                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM bdo.Booking_Payment WHERE Id=@id";
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                        scope.Complete()
                    }

                }
            }
        }
    }
}

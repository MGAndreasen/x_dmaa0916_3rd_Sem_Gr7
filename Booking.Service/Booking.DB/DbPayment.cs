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
    public class DbPayment : IDbCRUD<Payment>
    {
        private DataAccess data = DataAccess.Instance;

 

        public Payment Get(int id)
        {
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Payment WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                return new Payment
                {
                    Id = rdr.GetInt32(0),
                    Date = rdr.GetDateTime(1),
                    Amount = rdr.GetInt32(2)
                };
                }
        }

        public void Create(Payment obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Payment (Amount, Date) VALUES (@Amount, @Date)", con);
                    cmd.Parameters.Add("Amount", SqlDbType.Int).Value = obj.Amount;
                    cmd.Parameters.Add("Date", SqlDbType.DateTime).Value = obj.Date;
                    cmd.ExecuteNonQuery();

                }
                scope.Complete();
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
                    cmd.CommandText = "SELECT * FROM dbo.Booking_Payment";
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
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();

                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM dbo.Booking_Payment WHERE Id=@id";
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                        scope.Complete();
                    }

                }
            }
        }

        public void Update(Payment obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Booking SET Amount=@Amount, Date=@Date WHERE Id=@Id", con);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("Amount", SqlDbType.Int).Value = obj.Amount;
                    cmd.Parameters.Add("Date", SqlDbType.DateTime).Value = obj.Date;
                    cmd.ExecuteNonQuery();

                    cmd.ExecuteNonQuery();
                    scope.Complete();
                }
            }
        }
    }
}

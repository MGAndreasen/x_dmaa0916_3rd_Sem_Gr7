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
    public class DbTicket : IDbCRUD<Ticket>

    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Ticket Get(int id)
        {
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                try
                {
                    

                    SqlDataReader rdr = null;
                    SqlCommand cmd = new SqlCommand("SELECT FROM dbo.Booking_Ticket WHERE Id = @id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows())
                    {
                        while (rdr.Read())
                        {
                            return new Ticket
                            {
                                Id = rdr.GetInt32(0),

                            };
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

        }

        public void Create(Ticket obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Ticket (@Id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.ExecuteNonQuery();
                    {
                        //tilføj til model.
                    }
                }
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
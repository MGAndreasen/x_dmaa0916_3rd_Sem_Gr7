using Booking.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Booking_Ticket WHERE Id=@id", con);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                    scope.Complete();
                }
            }
        }

        public Ticket Get(int id)
        {
            DbPassenger dbp = new DbPassenger();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
             
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Booking WHERE Id=@Id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    SqlDataReader rdr = cmd.ExecuteReader();
                return new Ticket(rdr.GetInt32(0), dbp.Get(rdr.GetInt32(1)));

            }

        }

        public void Create(Ticket obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Booking (Id, Passenger_Id) VALUES (@Id, @Passenger_Id)", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Passenger_Id", SqlDbType.Int).Value = obj.Passenger;

                    cmd.ExecuteNonQuery();

                }
                scope.Complete();
            }
        }
        public void Update(Ticket obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Booking SET Id=@Id, Passenger_Id=@Passenger_Id", con);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Passenger_Id", SqlDbType.Int).Value = obj.Passenger;

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }
    }
}
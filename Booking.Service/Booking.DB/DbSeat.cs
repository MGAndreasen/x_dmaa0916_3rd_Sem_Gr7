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
    public class DbSeat : IDbCRUD<Seat>
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Booking_Seat WHERE Id=@id", con);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                    scope.Complete();
                }
            }

        }

        public Seat Get(int id)
        {
            DbRow dbRow = new DbRow();
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Seat WHERE Id=@Id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                return new Seat
                {
                    Id = rdr.GetInt32(0),
                    Row = dbRow.Get(rdr.GetInt32(1)),
                    Number = rdr.GetInt32(2),
                    Available = rdr.GetBoolean(3),
                };
                }
        }

        public void Create(Seat obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Seat (id, Row_Id, Number, Availability) VALUES (@id, @Number, @Availability)", con);
                    cmd.Parameters.Add("id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("Row_Id", SqlDbType.Int).Value = obj.Row.Id;
                    cmd.Parameters.Add("Number", SqlDbType.Int).Value = obj.Number;
                    cmd.Parameters.Add("Availability", SqlDbType.Bit).Value = obj.Available;

                    cmd.ExecuteNonQuery();
 
                }
                scope.Complete();
            }
        }
        public void Update(Seat obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Booking SET Id=@Id, Row_Id=@Row Number=@Number, Availability=@Availability", con);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Row", SqlDbType.Int).Value = obj.Row.Id;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = obj.Number;
                    cmd.Parameters.Add("@Availability", SqlDbType.Bit).Value = obj.Available;

                    cmd.ExecuteNonQuery();       
                } 
                scope.Complete();
            }
        }
    }
}

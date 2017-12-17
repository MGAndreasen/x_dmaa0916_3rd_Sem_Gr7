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
    public class DbSeat
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
            Seat s = null;

            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Seat WHERE Id=@Id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    s = new Seat
                    {
                        Id = (int)rdr["Id"],
                        Row = (int)rdr["Row_Id"],
                        Number = (string)rdr["Number"],
                        Available = (bool)rdr["Availability"]
                    };
                }

            }
            return s;
        }

        public List<Seat> GetAll(int departureId)
        {
            List<Seat> sList = new List<Seat>();

            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Seat WHERE Departure_Id=@DepartureId", con);
                cmd.Parameters.Add("@DepartureId", SqlDbType.Int).Value = departureId;

                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    sList.Add(new Seat
                    {
                        Id = (int)rdr["Id"],
                        Row = (int)rdr["Row_Id"],
                        Number = (string)rdr["Number"],
                        Available = (bool)rdr["Availability"]
                    });
                }

            }
            return sList;
        }

        public void Create(Seat obj, int departureId)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Seat (Row, Number, Departure_Id, Availability) VALUES (@Row, @Number, @DepartureId, @Availability)", con);
                    cmd.Parameters.Add("@Row", SqlDbType.Int).Value = obj.Row;
                    cmd.Parameters.Add("@Number", SqlDbType.NVarChar).Value = obj.Number;
                    cmd.Parameters.Add("@DepartureId", SqlDbType.Int).Value = departureId;
                    cmd.Parameters.Add("@Availability", SqlDbType.Bit).Value = obj.Available;

                    cmd.ExecuteNonQuery();

                }
                scope.Complete();
            }
        }
        public void Update(Seat obj, int departureId)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Booking SET Row=@Row, Number=@Number, Departure_Id=@DepartureId, Availability=@Availability WHERE Id=@id", con);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Row", SqlDbType.Int).Value = obj.Row;
                    cmd.Parameters.Add("@Number", SqlDbType.NVarChar).Value = obj.Number;
                    cmd.Parameters.Add("@DepartureId", SqlDbType.Int).Value = departureId;
                    cmd.Parameters.Add("@Availability", SqlDbType.Bit).Value = obj.Available;

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }
    }
}

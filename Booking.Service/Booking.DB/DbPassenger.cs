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
    public class DbPassenger : IDbCRUD<Passenger>
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

                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Booking_Passenger WHERE Id=@id";
                        cmd.Parameters.AddWithValue("Id", id);
                        cmd.ExecuteNonQuery();
                        scope.Complete();
                    }
                }
            }
        }

        public Passenger Get(int id)
        {
            Passenger p = null;
            DbBooking dbb = new DbBooking();
            DbSeat dbs = new DbSeat();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText= "SELECT * FROM dbo.Booking_Passenger WHERE Id = @Id";
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    p = new Passenger
                    {                       
                        Id = (int)reader["Id"],
                        Booking = dbb.Get((int)reader["Booking_Id"]),
                        SeatNumber = dbs.Get((int)reader["Seat_Id"]),
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        CPR = (long)reader["CPR"],
                        PassportId = (long)reader["PassportId"],
                        Luggage = (bool)reader["Luggage"]
                    };
                    
                }
                

            }
            return p;
        }

        public void Create(Passenger obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Passenger (Booking_Id, Seat_Id, FirstName, LastName, Cpr, PassportId, Luggage) Values (@Bo, @Seat, @FirstName, @LastName, @Cpr, @PassportId, @Luggage)", con);
                    cmd.Parameters.Add("@Bo", SqlDbType.Int).Value = obj.Booking.Id; // <-------------------------
                    cmd.Parameters.Add("@Seat", SqlDbType.Int).Value = obj.SeatNumber.Id; // <-------------------------
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = obj.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = obj.LastName;
                    cmd.Parameters.Add("@Cpr", SqlDbType.BigInt).Value = obj.CPR;
                    cmd.Parameters.Add("@PassportId", SqlDbType.BigInt).Value = obj.PassportId;
                    cmd.Parameters.Add("@Luggage", SqlDbType.Bit).Value = obj.Luggage;
                    cmd.ExecuteNonQuery();
          
                }
                scope.Complete();

            }
        }

        public void Update(Passenger obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Booking_Passenger SET Booking_Id=@Bo, Seat_Id=@Seat, FirstName = @FirstName, LastName = @LastName, Cpr = @Cpr, PassportId = @PassportId, Luggage = @Luggage WHERE Id=@Id", con);
                    
                    cmd.Parameters.AddWithValue("@Id", obj.Id);
                    cmd.Parameters.AddWithValue("@Bo", obj.Booking.Id); // <-------------------------
                    cmd.Parameters.AddWithValue("@Seat", obj.SeatNumber.Id); // <-------------------------
                    cmd.Parameters.AddWithValue("@FirstName", obj.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", obj.LastName);
                    cmd.Parameters.AddWithValue("@Cpr", obj.CPR);
                    cmd.Parameters.AddWithValue("@PassportId", obj.PassportId);
                    cmd.Parameters.AddWithValue("@Luggage", obj.Luggage);


                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }
        public IEnumerable<Passenger> GetAll()
        {
            DbBooking dbb = new DbBooking();
            DbSeat dbs = new DbSeat();
            List<Passenger> passengers = new List<Passenger>();
            using (SqlConnection con = new SqlConnection(DB.DataAccess.Instance.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM dbo.Booking_Passenger";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Passenger p = new Passenger
                        {
                            Id = (int)rdr["Id"],
                            Booking = dbb.Get((int)rdr["Booking_Id"]),
                            SeatNumber = dbs.Get((int)rdr["Seat_Id"]),
                            FirstName = (string)rdr["FirstName"],
                            LastName = (string)rdr["LastName"],
                            CPR = (long)rdr["Cpr"],
                            PassportId = (long)rdr["PassportId"],
                            Luggage = (bool)rdr["Luggage"]

                        };
                        passengers.Add(p);
                    }
                }

            }
            return passengers;
        }
    }
    
     
    
}

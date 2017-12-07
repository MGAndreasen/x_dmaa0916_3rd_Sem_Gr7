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
    public class DbDeparture : IDbCRUD<Departure>
    {
        private DataAccess data = DataAccess.Instance;

        public void Create(Departure obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Departure (StartDestination, EndDestination, DepartureTime, Plane_Id) VALUES (@StartDestination, @EndDestination, @DepartureTime, @Plane_Id)", con);
                    cmd.Parameters.Add("@StartDestination", SqlDbType.Int).Value = obj.StartDestination;
                    cmd.Parameters.Add("@EndDestination", SqlDbType.Int).Value = obj.EndDestination;
                    cmd.Parameters.Add("@DepartureTime", SqlDbType.DateTime).Value = obj.DepartureTime;
                    cmd.Parameters.Add("@Plane_Id", SqlDbType.Int).Value = obj.StartDestination;

                    cmd.ExecuteNonQuery();

                }
                scope.Complete();
            }
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
                        cmd.CommandText = "DELETE * FROM dbo.Booking_Departure WHERE Id = @id";
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                        cmd.ExecuteNonQuery();
                        scope.Complete();
                    }

                }
            }
        }

        public Departure Get(int id)
        {
            DbPlane dbp = new DbPlane();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Departure WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                return new Departure
                {
                    Id = (int)reader["Id"],
                    PlaneId = dbp.Get((int)reader["Plane_Id"]), 
                    EndDestination = (string)reader["EndDestination"],
                    DepartureTime = (DateTime)reader["DepartureTime"],
                    StartDestination = (string)reader["StartDestination"]
                };
            }
        }

        public void Update(Departure obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Departure SET StartDestination=@SD, EndDestination=@ED, DepartureTime=@DT, Plane_Id=@PI", con);

                    cmd.Parameters.Add("@SD", SqlDbType.Int).Value = obj.StartDestination;
                    cmd.Parameters.Add("@ED", SqlDbType.Int).Value = obj.EndDestination;
                    cmd.Parameters.Add("@DT", SqlDbType.DateTime).Value = obj.DepartureTime;
                    cmd.Parameters.Add("@PI", SqlDbType.Int).Value = obj.PlaneId.Id;

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }
    }
}

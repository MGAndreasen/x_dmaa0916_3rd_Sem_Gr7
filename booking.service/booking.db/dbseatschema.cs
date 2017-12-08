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
    public class DbSeatSchema : IDbCRUD<SeatSchema>
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Booking_SeatSchema WHERE Id=@id", con);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }
                scope.Complete();
            }

        }

        public SeatSchema Get(int id)
        {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_SeatSchema WHERE Id=@Id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.HasRows)
                {
                    rdr.Read();

                    return new SeatSchema
                    {
                        Id = (int)rdr["Id"],
                        PlaneId = (int)rdr["Plane_id"],
                        Row = (int)rdr["Row"],
                        Layout = (String)rdr["Layout"],
                    };

                }
                return null;
                }

        }

        public List<SeatSchema> GetAll(int planeId)
        {
            List<SeatSchema> schemas = new List<SeatSchema>();

            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_SeatSchema WHERE Plane_Id=@planeId", con);
                cmd.Parameters.Add("@PlaneId", SqlDbType.Int).Value = planeId;

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.HasRows)
                {
                    rdr.Read();

                    schemas.Add(
                    new SeatSchema
                    {
                        Id = (int)rdr["Id"],
                        PlaneId = (int)rdr["Plane_id"],
                        Layout = (String)rdr["Layout"],
                        Row = (int)rdr["Row"]
                    });

                }
                
            }

            return schemas;
        }

        public void Create(SeatSchema obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_SeatSchema (Id, Plane_id, Row, Layout) VALUES (@Id, @Plane_Id, @Row, @Layout)", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Plane_Id", SqlDbType.Int).Value = obj.PlaneId;
                    cmd.Parameters.Add("@Row", SqlDbType.Int).Value = obj.Row;
                    cmd.Parameters.Add("@Layout", SqlDbType.NVarChar).Value = obj.Layout;

                    cmd.ExecuteNonQuery();

                }
                scope.Complete();
            }
        }

        public void Update(SeatSchema obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_SeatSchema SET Id=@Id, Plane_id=@Plane_Id, Row=@Row, Layout=@Layout", con);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Row;
                    cmd.Parameters.Add("@Plane_Id", SqlDbType.Int).Value = obj.PlaneId;
                    cmd.Parameters.Add("@Row", SqlDbType.Int).Value = obj.Row;
                    cmd.Parameters.Add("@Layout", SqlDbType.NVarChar).Value = obj.Layout;


                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }
    }
}

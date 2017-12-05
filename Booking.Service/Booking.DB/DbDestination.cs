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
    public class DbDestination :IDbCRUD<Destination>
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
                        cmd.CommandText = "DELETE FROM dbo.booking_Destination WHERE Id=@id";
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                        scope.Complete();
                    }

                }
            }
        }

        public Destination Get(int id)
        {
            DbPlane dbp = new DbPlane();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Destination WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return new Destination
                {
                    Id = (int)reader["Id"],
                    Plane = dbp.Get((int)reader["Plane_Id"]), // <-------------------------
                    NameDestination = (string)reader["NameDestination"]
                };
            }
        }

        public void Create(Destination obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();                                                            //Id     //Plane_Id,            //@Id         //@Pi
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Destination (NameDestination, Plane_Id) VALUES (@Name, @Pi)", con);
                //    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                   cmd.Parameters.Add("@Pi", SqlDbType.Int).Value = obj.Plane.Id; // <-------------------------
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = obj.NameDestination;

                    cmd.ExecuteNonQuery();
                }

                scope.Complete();
            }
        }

        public void Update(Destination obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Destination SET Id=@Id, Plane_Id=@pi, NameDestination=@Name", con);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@pi", SqlDbType.Int).Value = obj.Plane.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = obj.NameDestination;


                    cmd.ExecuteNonQuery();
                }

                scope.Complete();
            }
        }

        public IEnumerable<Destination> GetAll()
        {
            DbPlane dbp = new DbPlane();
            List<Destination> destinations = new List<Destination>();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM dbo.Booking_Destination";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Destination d = new Destination
                        {
                            Id = (int)rdr["Id"],
                            Plane = dbp.Get((int)rdr["Plane_Id"]),
                            NameDestination = (String)rdr["NameDestination"],

                        };
                        destinations.Add(d);
                    }
                }

            }
            return destinations;
        }
    }

}

using Booking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Booking.DB.ScopeHelper;

namespace Booking.DB
{
    public class DbPlane : IDbCRUD<Plane>
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
                        cmd.CommandText = "DELETE FROM dbo.Booking_SeatSchema WHERE Plane_Id=@Plane_id";
                        cmd.Parameters.AddWithValue("Plane_id", id);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd2 = con.CreateCommand())
                    {
                        cmd2.CommandText = "DELETE FROM dbo.Booking_Plane WHERE Id=@id";
                        cmd2.Parameters.AddWithValue("id", id);
                        cmd2.ExecuteNonQuery();
                    }

                    scope.Complete();

                }
            }
        }

        public Plane Get(int id)
        {
            //DbSeatSchema dbs = new DbSeatSchema();
            Plane p = null;

            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT s.Id, s.Type FROM dbo.Booking_Plane AS s WHERE Id = @id", con))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    var rdr = cmd.ExecuteReader();

                    rdr.Read();

                    p = new Plane
                    {
                        Id = (int)rdr["Id"],
                        Type = (string)rdr["Type"]
                    };
                }

                using (SqlCommand cmd2 = new SqlCommand("SELECT * FROM dbo.Booking_SeatSchema WHERE Plane_Id=@Plane_id", con))
                {
                    cmd2.Parameters.Add("@Plane_Id", SqlDbType.Int).Value = id;

                    var rdr2 = cmd2.ExecuteReader();

                    while (rdr2.Read())
                    {
                        p.SeatSchema.Add(new SeatSchema { Id = (int)rdr2["Id"], Row = (int)rdr2["Row"], Layout = (string)rdr2["Layout"] });
                    }
                }

            }
            return p;
        }


        public void Create(Plane obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Plane (Type) VALUES(@Type)", con);
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = obj.Type;
                    cmd.ExecuteNonQuery();

                    //foreach (SeatSchema schema in obj.SeatSchema)
                    //{
                    //    using (SqlCommand cmd2 = new SqlCommand("INSERT INTO dbo.Booking_SeatSchema (Id, Plane_id, Row, Layout) VALUES (@Id, @Plane_Id, @Row, @Layout)", con))
                    //    {
                    //        cmd2.Parameters.Add("@Id", SqlDbType.Int).Value = schema.Id;
                    //        cmd2.Parameters.Add("@Plane_Id", SqlDbType.Int).Value = obj.Id;
                    //        cmd2.Parameters.Add("@Row", SqlDbType.Int).Value = schema.Row;
                    //        cmd2.Parameters.Add("@Layout", SqlDbType.NVarChar).Value = schema.Layout;
                    //        cmd2.ExecuteNonQuery();
                    //    }
                    //}

                }
                scope.Complete();
            }
        }

        public IEnumerable<Plane> GetAll()
        {
            //DbSeatSchema dbs = new DbSeatSchema();
            List<Plane> planes = new List<Plane>();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM dbo.Booking_Plane";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Plane p = new Plane
                        {
                            Id = (int)rdr["Id"],
                            Type = (String)rdr["Type"]
                        };

                        using (SqlCommand cmd2 = new SqlCommand("SELECT * FROM dbo.Booking_SeatSchema WHERE Plane_Id=@Plane_id", con))
                        {
                            cmd2.Parameters.Add("@Plane_Id", SqlDbType.Int).Value = p.Id;

                            var rdr2 = cmd2.ExecuteReader();

                            while (rdr2.Read())
                            {
                                p.SeatSchema.Add(new SeatSchema { Id = (int)rdr2["Id"], Row = (int)rdr2["Row"], Layout = (string)rdr2["Layout"] });
                            }
                        }
                        planes.Add(p);
                    }
                }

            }
            return planes;
        }

        public void Update(Plane obj)
        {

            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Booking SET Type=@Type ", con);

                    cmd.Parameters.Add("@Type", SqlDbType.Int).Value = obj.Type;

                    foreach (SeatSchema schema in obj.SeatSchema)
                    {
                        using (SqlCommand cmd2 = new SqlCommand("UPDATE dbo.Booking_SeatSchema SET Id=@Id, Plane_Id=@Plane_Id, Row=@Row, Layout=@Layout)", con))
                        {
                            cmd2.Parameters.Add("@Id", SqlDbType.Int).Value = schema.Id;
                            cmd2.Parameters.Add("@Plane_Id", SqlDbType.Int).Value = obj.Id;
                            cmd2.Parameters.Add("@Row", SqlDbType.Int).Value = schema.Row;
                            cmd2.Parameters.Add("@Layout", SqlDbType.NVarChar).Value = schema.Layout;
                            cmd2.ExecuteNonQuery();
                        }
                    }


                    cmd.ExecuteNonQuery();
                    scope.Complete();
                }
            }
        }
    }
}

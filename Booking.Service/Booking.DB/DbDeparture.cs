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
            
            List<SeatSchema> ss = new List<SeatSchema>();
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Departure (StartDestination, EndDestination, DepartureTime, Plane_Id) VALUES (@StartDestination, @EndDestination, @DepartureTime, @Plane_Id)", con);
                    cmd.Parameters.Add("@StartDestination", SqlDbType.Int).Value = obj.StartDestination.Id;
                    cmd.Parameters.Add("@EndDestination", SqlDbType.Int).Value = obj.EndDestination.Id;
                    cmd.Parameters.Add("@DepartureTime", SqlDbType.DateTime).Value = obj.DepartureTime;
                    cmd.Parameters.Add("@Plane_Id", SqlDbType.Int).Value = obj.Plane.Id;

                    cmd.ExecuteNonQuery();

                    if (obj.Plane != null)
                    {
                        
                        SqlCommand cmd2 = new SqlCommand("SELECT * FROM dbo.Booking_Seat WHERE Plane_Id=@Pid", con);
                        cmd2.Parameters.Add("@Pid", SqlDbType.Int).Value = obj.Plane.Id;

                        var rdr = cmd2.ExecuteReader();
                        bool Test = false;

                        while (rdr.Read()) 
                        {
                            Test = Convert.ToBoolean(rdr["Availability"]);

                            ss.Add(new SeatSchema
                            {
                                Id = (int)rdr["Id"],
                                Layout = (string)rdr["Layout"],
                                Row = (int)rdr["Row"]

                            });
                            
                            
                            //ss.Add(new SeatSchema { Id = (int)rdr["Id"], Number = (int)rdr["Number"], Row = (int)rdr["Row"], Available = Test });
                        }
                        foreach (var s in ss)
                        {
                            for (int i = 0; i < s.Layout.Length; i++)
                            {
                                if (s.Layout[i] != Convert.ToChar("|"))
                                {
                                    obj.Seats.Add(new Seat{ Number = (string)s.Layout[i].ToString(), Available=true, Row =s.Row });
                                }
                            }
                        }
                    }
                }
                scope.Complete();
                Update(obj);



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

                    // Husk at slette Seats også!

                }
            }
        }

        public Departure Get(int id)
        {
            DbPlane dbp = new DbPlane();
            DbDestination dbd = new DbDestination();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Departure WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                return new Departure
                {
                    Id = (int)rdr["Id"],
                    Plane = dbp.Get((int)rdr["Plane_Id"]),
                    EndDestination = dbd.Get((int)rdr["EndDestination"]),
                    StartDestination = dbd.Get((int)rdr["StartDestination"]),
                    DepartureTime = (DateTime)rdr["DepartureTime"]
                };

                // husk at tilføje seats til listen
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
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Departure SET StartDestination=@SD, EndDestination=@ED, DepartureTime=@DT, Plane_Id=@PI WHERE Id=@Id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@SD", SqlDbType.Int).Value = obj.StartDestination.Id;
                    cmd.Parameters.Add("@ED", SqlDbType.Int).Value = obj.EndDestination.Id;
                    cmd.Parameters.Add("@DT", SqlDbType.DateTime).Value = obj.DepartureTime;
                    cmd.Parameters.Add("@PI", SqlDbType.Int).Value = obj.Plane.Id;

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }

        public IEnumerable<Departure> GetAll()
        {
            DbPlane dbp = new DbPlane();
            DbDestination dbd = new DbDestination();

            List<Departure> departures = new List<Departure>();

            Departure d = null;
            

            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM dbo.Booking_Departure ORDER BY DepartureTime ASC";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        d = new Departure
                        {
                            Id = (int)rdr["Id"],
                            Plane = dbp.Get((int)rdr["Plane_Id"]),
                            EndDestination = dbd.Get((int)rdr["EndDestination"]),
                            StartDestination = dbd.Get((int)rdr["StartDestination"]),
                            DepartureTime = (DateTime)rdr["DepartureTime"]

                        };
                        // husk seats
                        departures.Add(d);
                    }
                }

            }

            int c = 0;
            foreach (var a in departures)
            {
                c++;
                c++;
                c++;

                foreach (var b in a.Seats)
                {
                    c++;
                }

                foreach (var dd in a.Plane.SeatSchema)
                {
                    c++;
                }
            }
            Console.WriteLine("Objects : " + c);
            return departures;
        }
    }

}

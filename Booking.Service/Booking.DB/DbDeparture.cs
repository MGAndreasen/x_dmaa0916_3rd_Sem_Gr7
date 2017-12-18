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

        private DbSeat dbSeat = new DbSeat();

        public void Create(Departure obj)
        {

            List<SeatSchema> seatSchemas = new List<SeatSchema>();
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Departure (StartDestination, EndDestination, DepartureTime, Plane_Id) VALUES (@StartDestination, @EndDestination, @DepartureTime, @Plane_Id); SELECT SCOPE_IDENTITY()", con);
                    cmd.Parameters.Add("@StartDestination", SqlDbType.Int).Value = obj.StartDestination.Id;
                    cmd.Parameters.Add("@EndDestination", SqlDbType.Int).Value = obj.EndDestination.Id;
                    cmd.Parameters.Add("@DepartureTime", SqlDbType.DateTime).Value = obj.DepartureTime;
                    cmd.Parameters.Add("@Plane_Id", SqlDbType.Int).Value = obj.Plane.Id;

                    obj.Id = Convert.ToInt32(cmd.ExecuteScalar());

                    if (obj.Plane != null)
                    {

                        SqlCommand cmd2 = new SqlCommand("SELECT * FROM dbo.Booking_SeatSchema WHERE Plane_Id=@Pid", con);
                        cmd2.Parameters.Add("@Pid", SqlDbType.Int).Value = obj.Plane.Id;

                        var rdr = cmd2.ExecuteReader();
                        //bool Test = false;

                        while (rdr.Read())
                        {
                            seatSchemas.Add(new SeatSchema
                            {
                                Id = (int)rdr["Id"],
                                Layout = (string)rdr["Layout"],
                                Row = (int)rdr["Row"]

                            });
                        }

                        if (obj.Seats == null)
                        {
                            obj.Seats = new List<Seat>();
                        }

                        foreach (var seatrow in seatSchemas)
                        {
                            for (int i = 0; i < seatrow.Layout.Length; i++)
                            {
                                if (seatrow.Layout[i] != Convert.ToChar("|"))
                                {
                                    // Det her er noget gris, vi burde kunne tilgå SeatsCtrl her fra, men kan vi ikke pga. noget cirkulær reference,
                                    //så vi burde flytte ALT logik et lag længere op i BLL for at kunne gøre det smukkere.
                                    // -- Vh. Michael
                                    //dbSeat.Create(new Seat { Number = (string)seatrow.Layout[i].ToString(), Available = true, Row = seatrow.Row }, obj.Plane.Id);

                                    obj.Seats.Add(new Seat { Number = (string)seatrow.Layout[i].ToString(), Available = true, Row = seatrow.Row });
                                }
                            }
                        }
                    }
                }
                 
                scope.Complete();
                //Vi bliver nød til at afslutte transactionen her fordi vi kalder den også i DBSeat så de kolidere i en SQL manager netværks fejl!
                // det skal flyttes over i CTRL stortset altsammen!

                
                foreach (var s in obj.Seats)
                {
                    dbSeat.Create(s, obj.Id);
                }
                //Update(obj);
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
                        cmd.CommandText = "DELETE FROM dbo.Booking_Departure WHERE Id = @id";
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
                    DepartureTime = (DateTime)rdr["DepartureTime"],
                    Seats = dbSeat.GetAll((int)rdr["Id"])
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

            return departures;
        }

        public IEnumerable<Departure> GetAllDeparturesFromTo(int start, int end, DateTime fromDate, DateTime toDate)
        {
            DbPlane dbp = new DbPlane();
            DbDestination dbd = new DbDestination();

            List<Departure> departures = new List<Departure>();

            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM dbo.Booking_Departure Where StartDestination = @start AND EndDestination = @end AND DepartureTime >= @fromDate AND DepartureTime <= @toDate ORDER BY DepartureTime ASC";
                    cmd.Parameters.Add("@start", SqlDbType.Int).Value = start;
                    cmd.Parameters.Add("@end", SqlDbType.Int).Value = end;
                    cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDate;
                    cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate;
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        departures.Add(new Departure
                        {
                            Id = (int)rdr["Id"],
                            //Plane = dbp.Get((int)rdr["Plane_Id"]),
                            //EndDestination = dbd.Get((int)rdr["EndDestination"]),
                            //StartDestination = dbd.Get((int)rdr["StartDestination"]),
                            DepartureTime = (DateTime)rdr["DepartureTime"]
                        });
                        // husk seats
                    }
                }

            }

            return departures;
        }
    }

}

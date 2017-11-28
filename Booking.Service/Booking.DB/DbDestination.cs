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
    public class DbDestination :IDbCRUD<Destination>
    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();

                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM bdo.booking_Destination WHERE Id=@id";
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                        scope.Complete();
                    }

                }
            }
        }

        public Destination Get(int id)
        {
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  Id FROM dbo.Booking_Destination AS s WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader reader = cmd.ExecuteReader();
                return new Destination
                {
                    Id = reader.GetInt32(0),
                    LocationName = reader.GetString(1)
                };
            }
        }

        public void Create(Destination obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO bdo.Booking_Destination (Id, NameDestination) VALUES (@Id, @Name)", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = obj.LocationName;
                   
                    {
                        //tilføj til model.
                    }
                }
            }
        }

        public void Update(Destination obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Destination SET Id=@Id, NameDestination=@Name", con);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = obj.LocationName;


                    cmd.ExecuteNonQuery();
                    scope.Complete();
                }
            }
        }

        public IEnumerable<Destination> GetAll()
        {
            List<Destination> destinations = new List<Destination>();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM bdo.Booking_Destination";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Destination d = new Destination
                        {
                            Id = (int)rdr["Id"],
                            LocationName = (String)rdr["Type"],


                        };
                        destinations.Add(d);
                    }
                }

            }
            return destinations;
        }
    }

}

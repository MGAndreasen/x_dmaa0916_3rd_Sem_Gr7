using Booking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace Booking.DB
{
    public class DbPlane : IDbCRUD<Plane>
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
                        cmd.CommandText = "DELETE FROM bdo.Booking_Plane WHERE Id=@id";
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                        scope.Complete();
                    }

                }
            }
        }

        public Plane Get(int id)
        {
            DbSeatSchema dbs = new DbSeatSchema();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
 //               try
                {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT s.Id, s.SeatSchema_Id, s.Type FROM dbo.Booking_Plane AS s WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                var rdr = cmd.ExecuteReader();

                while (rdr.HasRows)
                {
                    rdr.Read();

                    return new Plane
                    {
                        Id = (int)rdr["Id"],
                        SeatSchema = dbs.Get((int)rdr["SeatSchema_Id"]),
                        Type = (string)rdr["Type"]
                    };

                }
                return null;
                }
        }

        public void Create(Plane obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Plane (@Id, @SeatSchema_Id, @Type)", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@SeatSchema_Id", SqlDbType.Int).Value = obj.SeatSchema;
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = obj.Type;
                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }

        public IEnumerable<Plane> GetAll()
        {
            DbSeatSchema dbs = new DbSeatSchema();
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
                            SeatSchema = dbs.Get((int)rdr["SeatSchema_Id"]),
                            Type = (String)rdr["Type"],
                            

                        };
                       planes.Add(p);
                    }
                }

            }
            return planes;
        }

        public void Update(Plane obj)
        {
            throw new NotImplementedException();
        }
    }
}

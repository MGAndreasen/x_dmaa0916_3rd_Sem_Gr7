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
    public class DbRow : IDbCRUD<Row>
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
                        cmd.CommandText = "DELETE * FROM dbo.Booking_Row WHERE Id=@id";
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                        scope.Complete();

                    }

                }
            }
        }

        public Row Get(int id)
        {
            DbSeatSchema dbs = new DbSeatSchema();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                try
                {
                    SqlDataReader rdr = null;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Row WHERE Id = @id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    rdr = cmd.ExecuteReader();

                    rdr.Read();
                        return new Row
                        {
                            Id = rdr.GetInt32(0),
                            SeatNumber = dbs.Get(rdr.GetInt32(1)),
                            Price = rdr.GetInt32(2)
                        };

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            return null;
        }

        public void Create(Row obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Booking (Id, SeatNumber, Price) VALUES (@Id, @SeatNumber, @Price)", con);
                    cmd.Parameters.Add("Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("SeatNumber", SqlDbType.Int).Value = obj.SeatNumber;
                    cmd.Parameters.Add("Price", SqlDbType.Float).Value = obj.Price;
                    cmd.ExecuteNonQuery();
                    
                }
                scope.Complete();
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Row> GetAll()
        {
            DbSeatSchema dbs = new DbSeatSchema();
            List<Row> rows = new List<Row>();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Row";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Row r = new Row
                        {
                            Id = (int)rdr["Id"],
                            SeatNumber = dbs.Get((int)rdr["SeatNumber"]),
                            Price = (int)rdr["Price"],
                        };
                       rows.Add(r);
                    }
                }

            }
            return rows;
        }

        public void Update(Row obj)
        {
            throw new NotImplementedException();
        }
    }
}

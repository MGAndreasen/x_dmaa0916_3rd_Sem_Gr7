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
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();

                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM bdo.Booking_Row WHERE Id=@id";
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                        scope.Complete();

                    }

                }
            }
        }

        public Row Get(int id)
        {
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                try
                {
                    con.Open();
                    SqlDataReader rdr = null;
                    SqlCommand cmd = new SqlCommand("SELECT FROM dbo.Booking_Row WHERE Id = @id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        return new Row
                        {
                            Id = rdr.GetInt32(0),
                            SeatNumber = rdr.GetInt32(1),
                            Price = rdr.GetInt32(2)
                        };
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
        }

        public void Create(Row obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Booking (@Id, @SeatNumber, @Price", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@SeatNumber", SqlDbType.Int).Value = obj.SeatNumber;
                    cmd.Parameters.Add("@Price", SqlDbType.Float).Value = obj.Price;
                    cmd.ExecuteNonQuery();
                    scope.Complete();

                    {
                        //tilføj til model.
                    }
                }
            }
        }

        public void Update(Row obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Row SET Id=@Id, SeatNumber=@SN, Price=@PR", con);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@SN", SqlDbType.Int).Value = obj.SeatNumber;
                    cmd.Parameters.Add("@PR", SqlDbType.Int).Value = obj.Price;
                    cmd.ExecuteNonQuery();
                    scope.Complete();
                }
            }
        }

        public IEnumerable<Row> GetAll()
        {
            List<Row> rows = new List<Row>();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM bdo.Booking_Row";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Row r = new Row
                        {
                            Id = (int)rdr["Id"],
                            SeatNumber = (int)rdr["SeatNumber"],
                            Price = (double)rdr["Price"],
                        };
                       rows.Add(r);
                    }
                }

            }
            return rows;
        }
    }
}

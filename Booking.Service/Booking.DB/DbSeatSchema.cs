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
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Booking_SeatSchema WHERE Id=@id", con);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                    scope.Complete();
                }
            }

        }

        public SeatSchema Get(int id)
        {
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_SeatSchema WHERE Id=@Id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    SqlDataReader rdr = cmd.ExecuteReader();
                    return new SeatSchema
                    {
                        Row = rdr.GetInt32(0),
                        Layout = rdr.GetString(1),
                    };
                }

            }

        }

        public void Create(SeatSchema obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_SeatSchema (Row, Layout) VALUES (@Row, @Layout)", con);
                    cmd.Parameters.Add("Row", SqlDbType.Int).Value = obj.Row;
                    cmd.Parameters.Add("Layout", SqlDbType.VarChar).Value = obj.Layout;

                    cmd.ExecuteNonQuery();

                    scope.Complete();
                }
            }
        }

        public void Update(SeatSchema obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_SeatSchema SET Row=@Row, Layout=@Layout", con);

                    cmd.Parameters.Add("@Row", SqlDbType.Int).Value = obj.Row;
                    cmd.Parameters.Add("@Layout", SqlDbType.Int).Value = obj.Layout;


                    cmd.ExecuteNonQuery();
                    scope.Complete();
                }
            }
        }
    }
}

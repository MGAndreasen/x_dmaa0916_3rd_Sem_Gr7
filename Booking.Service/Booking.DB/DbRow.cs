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
            throw new NotImplementedException();
        }

        public Row Get(int id)
        {
            throw new NotImplementedException();
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
                    cmd.Parameters.Add("@Price", SqlDbType.Int).Value = obj.Price;
                    cmd.ExecuteNonQuery();
                    {
                        //tilføj til model.
                    }
                }
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}

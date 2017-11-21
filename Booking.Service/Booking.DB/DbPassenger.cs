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
    public class DbPassenger : IDbCRUD<Passenger>

    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Passenger Get(int id)
        {
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("SELECT FROM dbo.Booking_Passenger WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();
                    return new Passenger
                    {
                        Id = rdr.GetInt32(0),
                        FirstName = rdr.GetString(1),
                        LastName = rdr.GetString(2),
                        CPR = rdr.GetInt64(3),
                        PassportId = rdr.GetInt64(4),
                        Luggage = rdr.GetBoolean(5),
                    };

            }

        }

        public void Create(Passenger obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Passenger (@Id, @FirstName, @LastName, @Cpr, @PassportId, @Luggage", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = obj.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = obj.LastName;
                    cmd.Parameters.Add("@Cpr", SqlDbType.BigInt).Value = obj.CPR;
                    cmd.Parameters.Add("@PassportId", SqlDbType.BigInt).Value = obj.PassportId;
                    cmd.Parameters.Add("@Luggage", SqlDbType.Bit).Value = obj.Luggage;
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

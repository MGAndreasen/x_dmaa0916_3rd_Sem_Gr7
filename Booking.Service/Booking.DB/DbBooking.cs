using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using Booking.Models;
using System.Transactions;


namespace Booking.DB
{
    public class DbBooking : IDbCRUD<Bookings>
    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Bookings Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Bookings obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ........", con);
                    //cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = variable;
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        //tilføj til model.
                    }
                    scope.Complete(); //pas hvornår den skal stå...??
                }
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
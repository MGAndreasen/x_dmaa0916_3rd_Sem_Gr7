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
    public class DbCity : IDbCRUD<City>
    {

        private DataAccess data = DataAccess.Instance;


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public City Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(City obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_City (@Zipcode, @Name)", con);
                    cmd.Parameters.Add("@Zipcode", SqlDbType.SmallInt).Value = obj.Zipcode;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = obj.CityName;

                    cmd.ExecuteNonQuery();
                    scope.Complete(); 
                }
            }
        }

        public void Update(string name)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_City WHERE City=@City", con);

                    cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = name; 

                    cmd.ExecuteNonQuery();
                    scope.Complete(); 
                }
            }

        }
    }
}





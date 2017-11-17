using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
namespace Booking.DB
{
    public class DbBooking : IDbCRUD<Booking>
    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Booking Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Booking obj)
        {
            using (/*Transaction*/)
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
                }
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DB
{
    public class DbSeatSchema : IDbCRUD<SeatSchema>
    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public SeatSchema Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(SeatSchema obj)
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
}

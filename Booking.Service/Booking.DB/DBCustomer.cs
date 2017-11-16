using Booking.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DB
{
    public class DbCustomer : IDbCRUD<Customer>
    {
        private DataAccess data = DataAccess.Instance;

        public void Create(Customer obj)
        {
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
            }
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}

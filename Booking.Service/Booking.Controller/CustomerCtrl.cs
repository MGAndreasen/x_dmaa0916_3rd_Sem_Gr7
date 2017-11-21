using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class CustomerCtrl : ICRUD<Customer>
    {
        public void Create(Customer obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            DbCustomer dbCustomer = new DbCustomer();
            return dbCustomer.Get(id);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}

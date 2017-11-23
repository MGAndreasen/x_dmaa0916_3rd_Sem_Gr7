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
            obj = new Customer();
            DbCustomer DBC = new DbCustomer();

            DBC.Create(obj);

        }

        public void Delete(int id)
        {
            DbCustomer DBC = new DbCustomer();

            DBC.Delete(id);
        }

        public Customer Get(int id)
        {
            DbCustomer DBC = new DbCustomer();
            Customer c = DBC.Get(id);

            return c;
        }

        public void Update(Customer obj, int id)
        {
            DbCustomer DBC = new DbCustomer();
            obj = DBC.Get(id);

            DBC.Update(obj);
        }
    }
}

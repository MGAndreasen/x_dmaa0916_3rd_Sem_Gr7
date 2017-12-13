using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class CustomerCtrl
    {
        private DbCustomer DBC = new DbCustomer();

        public bool Create(Customer obj)
        {
            return DBC.Create(obj);
        }

        public void Delete(int id)
        {
            DBC.Delete(id);
        }

        public Customer Get(int id)
        {
            return DBC.Get(id);
        }

        public void Update(Customer obj)
        {
            DBC.Update(obj);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return DBC.GetAllCustomers();
        }

        public int GetActivityCount()
        {
            return DBC.CountOnline();
        }

        public void UpdActivity(int id)
        {
            DBC.UpdActivity(id);
        }
    }
}

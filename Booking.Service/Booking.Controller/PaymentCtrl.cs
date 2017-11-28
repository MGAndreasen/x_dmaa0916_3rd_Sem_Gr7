using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class PaymentCtrl : ICRUD<Payment>
    {
        private DbPayment DBP = new DbPayment();
        public void Create(Payment obj)
        {
            DBP.Create(obj);
        }

        public void Delete(int id)
        {
            DBP.Delete(id);
        }

        public Payment Get(int id)
        {
            return DBP.Get(id);
        }

        public void Update(Payment obj)
        {
            DBP.Update(obj);
        }
    }
}

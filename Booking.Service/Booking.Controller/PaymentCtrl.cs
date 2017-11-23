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
        public void Create(Payment obj)
        {
            obj = new Payment();
            DbPayment DBP = new DbPayment();

            DBP.Create(obj);
        }

        public void Delete(int id)
        {
            DbPayment DBP = new DbPayment();
            DBP.Delete(id);
        }

        public Payment Get(int id)
        {
            DbPayment DBP = new DbPayment();
            Payment pm = DBP.Get(id);

            return pm;
        }

        public void Update(Payment obj)
        {
            DbPayment DBP = new DbPayment();
            DBP.Update(obj);
        }
    }
}

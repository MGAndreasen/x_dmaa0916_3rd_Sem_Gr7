using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class BookingCtrl : ICRUD<Bookings>
    {
        private DbBooking DBB = new DbBooking();
        public void Create(Bookings obj)
        {
            DBB.Create(obj);
        }

        public void Delete(int id)
        {
            DBB.Delete(id);
        }

        public Bookings Get(int id)
        {

            return DBB.Get(id);
        }

        public void Update(Bookings obj)
        {
            DBB.Update(obj);
        }
    }
}

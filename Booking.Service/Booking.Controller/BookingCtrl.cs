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
        public void Create(Bookings obj)
        {
            obj = new Bookings();
            DbBooking DBB = new DbBooking();

            DBB.Create(obj);
        }

        public void Delete(int id)
        {
            DbBooking DBB = new DbBooking();

            DBB.Delete(id);
        }

        public Bookings Get(int id)
        {

            DbBooking DBB = new DbBooking();
            Bookings b = DBB.Get(id); 


            return b; 
        }

        public void Update(Bookings obj, int id)
        {
            DbBooking DBB = new DbBooking();
            obj = DBB.Get(id);

            DBB.Update(obj);
        }
    }
}

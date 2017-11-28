using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class SeatCtrl : ICRUD<Seat>
    {
        private static DbSeat dbs = new DbSeat();
        public void Create(Seat obj)
        {
            dbs.Create(obj);
        }

        public void Delete(int id)
        {
            dbs.Delete(id);
        }

        public Seat Get(int id)
        {
            return dbs.Get(id);
        }

        public void Update(Seat obj)
        {
            dbs.Update(obj);
        }
    }
}

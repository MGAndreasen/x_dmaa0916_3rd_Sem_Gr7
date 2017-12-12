using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class SeatCtrl
    {
        private static DbSeat dbs = new DbSeat();
        public void Create(Seat obj, int plainID)
        {
            dbs.Create(obj, plainID);
        }

        public void Delete(int id)
        {
            dbs.Delete(id);
        }

        public Seat Get(int id)
        {
            return dbs.Get(id);
        }

        public void Update(Seat obj, int planeId)
        {
            dbs.Update(obj, planeId);
        }
    }
}

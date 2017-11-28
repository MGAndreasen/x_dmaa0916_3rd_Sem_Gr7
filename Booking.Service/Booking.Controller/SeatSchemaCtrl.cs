using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class SeatSchemaCtrl : ICRUD<SeatSchema>
    {
        private DbSeatSchema dbss = new DbSeatSchema();
        public void Create(SeatSchema obj)
        {
            dbss.Create(obj);
        }

        public void Delete(int id)
        {
            dbss.Delete(id);
        }

        public SeatSchema Get(int id)
        {
            return dbss.Get(id);
        }

        public void Update(SeatSchema obj)
        {
            dbss.Update(obj);
        }
    }
}

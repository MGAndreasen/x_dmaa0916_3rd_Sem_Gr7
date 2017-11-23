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
        public void Create(SeatSchema obj)
        {
            obj = new SeatSchema();
            DbSeatSchema dbss = new DbSeatSchema();

            dbss.Create(obj);
        }

        public void Delete(int id)
        {
            DbSeatSchema dbss = new DbSeatSchema();

            dbss.Delete(id);
        }

        public SeatSchema Get(int id)
        {
            DbSeatSchema dbss = new DbSeatSchema();
            SeatSchema ss = dbss.Get(id);

            return ss; 
        }

        public void Update(SeatSchema obj)
        {
            DbSeatSchema dbss = new DbSeatSchema();
            dbss.Update(obj);
        }
    }
}

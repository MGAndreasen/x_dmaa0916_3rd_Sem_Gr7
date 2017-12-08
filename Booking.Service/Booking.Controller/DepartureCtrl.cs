using Booking.DB;
using Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Controller
{
    public class DepartureCtrl : ICRUD<Departure>
    {
        private DbDeparture DBP = new DbDeparture();

        public void Create(Departure obj)
        {
            DBP.Create(obj);
        }

        public void Delete(int id)
        {
            DBP.Delete(id);
        }

        public Departure Get(int id)
        {
            return DBP.Get(id);
        }

        public void Update(Departure obj)
        {
            DBP.Update(obj);
        }

        public IEnumerable<Departure> GetAllDepartures()
        {
           return DBP.GetAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class CityCtrl : ICRUD<City>
    {
        public void Create(City obj)
        {
            obj = new City();
            DbCity DBCI = new DbCity();

            DBCI.Create(obj);
        }

        public void Delete(int id)
        {
            DbCity DBCI = new DbCity();
            DBCI.Delete(id);

            
        }

        public City Get(int id)
        {
            DbCity DBCI = new DbCity();
            City c = DBCI.Get(id);

            return c; 
        }

        public void Update(City obj, int id)
        {
            DbCity DBCI = new DbCity();
            obj = DBCI.Get(id);

            DBCI.Update(obj);
        }
    }
}

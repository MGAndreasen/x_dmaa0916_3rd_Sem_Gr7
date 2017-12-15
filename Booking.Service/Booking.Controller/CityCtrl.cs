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
        private DbCity DBCI = new DbCity();
        public void Create(City obj)
        {
            DBCI.Create(obj); 
        }

        public void Delete(int id)
        {
            DBCI.Delete(id);
        }

        public City Get(int id)
        {
            return DBCI.Get(id);
        }

        public void Update(City obj)
        {
            DBCI.Update(obj);
        }

        public IEnumerable<City> GetAllCitys()
        {
            return DBCI.GetAll();
        }
    }
}

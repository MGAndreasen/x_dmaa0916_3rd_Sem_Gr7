using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class PassengerCtrl : ICRUD<Passenger>
    {
        private DbPassenger dbp = new DbPassenger();
        public void Create(Passenger obj)
        {
            dbp.Create(obj);
        }

        public void Delete(int id)
        {
            dbp.Delete(id);
        }

        public Passenger Get(int id)
        {
            return dbp.Get(id);            
        }

        public void Update(Passenger obj)
        {
            dbp.Update(obj);
        }

        public IEnumerable<Passenger> GetAllPassengers()
        {
            return dbp.GetAll();
        }
    }
}

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
        public void Create(Passenger obj)
        {
            obj = new Passenger();
            DbPassenger DBP = new DbPassenger();


            DBP.Create(obj);
        }

        public void Delete(int id)
        {
            DbPassenger DBP = new DbPassenger();
            DBP.Delete(id);
        }

        public Passenger Get(int id)
        {
            DbPassenger DBP = new DbPassenger();
            Passenger p = DBP.Get(id);

            return p; 
            
        }

        public void Update(Passenger obj)
        {
            DbPassenger DBP = new DbPassenger();

            DBP.Update(obj);
        }
    }
}

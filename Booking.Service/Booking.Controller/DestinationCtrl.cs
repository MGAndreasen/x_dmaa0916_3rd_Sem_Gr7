using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class DestinationCtrl : ICRUD<Destination>
    {
        private DbDestination db = new DbDestination();

        public void Create(Destination obj)
        {
            db.Create(obj);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public Destination Get(int id)
        {
            return db.Get(id);
        }

        public void Update(Destination obj)
        {
            db.Update(obj);
        }

        public IEnumerable<Destination> GetAllDestinations()
        {
            return db.GetAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class PlaneCtrl : ICRUD<Plane>
    {
        private DbPlane DBP = new DbPlane();
        public void Create(Plane obj)
        {
            DBP.Create(obj);
        }

        public void Delete(int id)
        {
            DBP.Delete(id);
        }

        public Plane Get(int id)
        {
            return DBP.Get(id);
        }

        public void Update(Plane obj)
        {
            DBP.Update(obj);
        }
        public IEnumerable<Plane> GetAllPlanes()
        {
            return DBP.GetAll();
        }
    }

    
}

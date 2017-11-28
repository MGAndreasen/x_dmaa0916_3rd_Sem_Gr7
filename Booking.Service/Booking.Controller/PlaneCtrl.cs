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
        public void Create(Plane obj)
        {
            obj = new Plane();
            DbPlane DBP = new DbPlane();

            DBP.Create(obj);
        }

        public void Delete(int id)
        {
            DbPlane DBP = new DbPlane();

            DBP.Delete(id);
        }

        public Plane Get(int id)
        {
            DbPlane DBP = new DbPlane();
            Plane pl = DBP.Get(id);

            return pl; 
        }

        public void Update(Plane obj)
        {
            DbPlane DBP = new DbPlane();
            DBP.Update(obj);
        }
        public IEnumerable<Plane> GetAllPlanes()
        {
            DbPlane DBP = new DbPlane();

            return DBP.GetAll();
        }
    }

    
}

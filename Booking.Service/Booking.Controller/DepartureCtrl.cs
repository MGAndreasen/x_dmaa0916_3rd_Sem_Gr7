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
        private DestinationCtrl dCtrl = new DestinationCtrl();

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

        public IEnumerable<Departure> GetAllTilbud()
        {
            var allDept = DBP.GetAll();
            var allDest = dCtrl.GetAllDestinations();
            bool added;

            List<Departure> toReturn = new List<Departure>();

            foreach(var dest in allDest)
            {
                added = false;

                foreach (var dept in allDept)
                {
                    if (added)
                    {
                        continue;
                    }
                    else
                    {
                        if (dept.EndDestination.Id == dest.Id)
                        {
                            toReturn.Add(dept);
                            added = true;
                        }
                    }
                }
            }

            return toReturn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class RowCtrl : ICRUD<Row>
    {
        private DbRow DBR = new DbRow();
        public void Create(Row obj)
        {
            DBR.Create(obj);
        }

        public void Delete(int id)
        {
            DBR.Delete(id); 
        }

        public Row Get(int id)
        {
            return DBR.Get(id);
        }

        public void Update(Row obj)
        {
            DBR.Update(obj);
        }
    }
}

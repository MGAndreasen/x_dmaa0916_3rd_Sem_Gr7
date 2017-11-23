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
        public void Create(Row obj)
        {
            obj = new Row();
            DbRow DBR = new DbRow();

            DBR.Create(obj);
        }

        public void Delete(int id)
        {
            DbRow DBR = new DbRow();

            DBR.Delete(id); 
        }

        public Row Get(int id)
        {
            DbRow DBR = new DbRow();
            Row r = DBR.Get(id);

            return r; 
        }

        public void Update(Row obj)
        {
            DbRow DBR = new DbRow();
            DBR.Update(obj);
        }
    }
}

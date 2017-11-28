using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
using Booking.DB;

namespace Booking.Controller
{
    public class TicketCtrl : ICRUD<Ticket>
    {
        private DbTicket dbt = new DbTicket();
        public void Create(Ticket obj)
        {
            dbt.Create(obj);
        }

        public void Delete(int id)
        {
            dbt.Delete(id);
        }

        public Ticket Get(int id)
        {
            return dbt.Get(id);
        }

        public void Update(Ticket obj)
        {
            dbt.Update(obj);
        }
    }
}

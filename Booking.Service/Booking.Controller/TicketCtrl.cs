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
        public void Create(Ticket obj)
        {
            DbTicket dbt = new DbTicket();
            obj = new Ticket();

            dbt.Create(obj);
        }

        public void Delete(int id)
        {
            DbTicket dbt = new DbTicket();

            dbt.Delete(id);
        }

        public Ticket Get(int id)
        {
            DbTicket dbt = new DbTicket();

            Ticket t = dbt.Get(id);


            return t; 
        }

        public void Update(Ticket obj)
        {
            DbTicket dbt = new DbTicket();
            dbt.Update(obj);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking.Test
{
    [TestClass]
    public class DBCity
    {
        [TestMethod()]
        public void Create()
        {
            Booking.Models.Ticket c = new Models.Ticket(1);
            Booking.DB.DbTicket dbT = new DB.DbTicket();

            Assert.AreNotEqual(c, dbT.Get(1));

            dbT.Create(c);

            Assert.AreEqual(c, dbT.Get(9999));


            
        }

        public void Read()
        {




        }

        public void Update()
        {




        }

        public void Delete()
        {




        }
    }
}

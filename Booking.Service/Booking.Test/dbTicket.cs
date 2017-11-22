using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking.Test
{
    [TestClass]
    public class dbTicket
    {
        [TestMethod]
        public void TestMethod1()
        {
            Booking.Models.Ticket c = new Models.Ticket(1);
            Booking.DB.DbTicket dbT = new DB.DbTicket();

            Assert.AreNotEqual(c, dbT.Get(1));

            dbT.Create(c);

            Assert.AreEqual(c, dbT.Get(9999));
        }
    }
}

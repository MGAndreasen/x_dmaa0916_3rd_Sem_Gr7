using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking.Test
{
    [TestClass]
    public class DBPassengers
    {
        [TestMethod]
        public void PassengersCreate()
        {
            Models.Passenger p = new Models.Passenger();
            p.Id = 999999;
            p.FirstName = "Svend";
            p.LastName = "Andersen";
            p.Luggage = true;
            p.PassportId = 1234567890;
            p.SeatNumber = null;


            Booking.DB.DbPassenger dbPass = new DB.DbPassenger();
            dbPass.Delete(999999);

            Assert.IsNull(dbPass.Get(999999));
                       
            dbPass.Create(p);


            Assert.IsNotNull(dbPass.Get(999999));
          
            Assert.AreEqual(p.PassportId, dbPass.Get(999999).PassportId);

        }

        [TestMethod]
        public void PassengersRead()
        {
            Models.Passenger p = new Models.Passenger();
            p.Id = -1;
            p.FirstName = "Svend";
            p.LastName = "Andersen";
            p.Luggage = true;
            p.PassportId = 1234567890;
            p.SeatNumber = null;


            DB.DbPassenger dbPass = new DB.DbPassenger();
            dbPass.Delete(p.Id);

            Assert.IsNull(dbPass.Get(p.Id));

            dbPass.Create(p);

            Assert.AreEqual(p.PassportId, dbPass.Get(p.Id).PassportId);
        }

        [TestMethod]
        public void PassengersUpdate()
        {

            Models.Passenger p = new Models.Passenger();
            p.Id = -1;
            p.FirstName = "Svend";
            p.LastName = "Andersen";
            p.Luggage = true;
            p.PassportId = 1234567890;
            p.SeatNumber = null;


            DB.DbPassenger dbPass = new DB.DbPassenger();
            dbPass.Delete(-1);

            Assert.AreNotEqual(p.PassportId, dbPass.Get(-1).PassportId);

            dbPass.Create(p);

            Assert.AreEqual(p.PassportId, dbPass.Get(-1).PassportId);

            p.PassportId = 0987654321;

            dbPass.Update(p);

            Assert.AreEqual(p.PassportId, dbPass.Get(-1).PassportId);

        }

        [TestMethod]
        public void PassengersDelete()
        {
            Booking.DB.DbPassenger dbPassenger = new DB.DbPassenger();

            dbPassenger.Delete(999999);

            Assert.IsNull(dbPassenger.Get(999999));

        }
    }
}

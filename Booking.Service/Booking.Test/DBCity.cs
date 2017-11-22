using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking.Test
{
    [TestClass]
    public class DBCity
    {
        [TestMethod()]
        public void CityCreate()
        {
            Booking.Models.City c = new Models.City(9999, "Test");
            Booking.DB.DbCity dbCity = new DB.DbCity();

            dbCity.Delete(9999);

            Assert.IsNull(dbCity.Get(9999));

            dbCity.Create(c);


            
            Assert.AreEqual(c.Zipcode, dbCity.Get(9999).Zipcode);


            
        }

        [TestMethod()]
        public void CityRead()
        {
            Booking.Models.City c = new Models.City(9999, "Test");
            Booking.DB.DbCity dbCity = new DB.DbCity();

            dbCity.Delete(9999);
            dbCity.Create(c);

            Assert.IsNotNull(dbCity.Get(9999));
        }

        [TestMethod()]
        public void CityUpdate()
        {
            Booking.Models.City c = new Models.City(9999, "Test");
            Booking.DB.DbCity dbCity = new DB.DbCity();

            dbCity.Delete(9999);
            dbCity.Create(c);

            Assert.AreEqual(dbCity.Get(9999).CityName , "Test");

            c.CityName = "Changed";

            dbCity.Update(c);

            Assert.AreEqual(dbCity.Get(9999).CityName, "Changed");

        }

        [TestMethod()]
        public void CityDelete()
        {
            Booking.Models.City c = new Models.City(9999, "Test");
            Booking.DB.DbCity dbCity = new DB.DbCity();

            dbCity.Delete(9999);
            dbCity.Create(c);

            if (dbCity.Get(9999).Zipcode == c.Zipcode)
            {
                dbCity.Delete(9999);
                Assert.IsNull(dbCity.Get(9999));
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}

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
            Booking.Models.City c = new Models.City(9999, "Test");
            Booking.DB.DbCity dbCity = new DB.DbCity();

            dbCity.Delete(9999);

            Assert.IsNull(dbCity.Get(9999));

            dbCity.Create(c);

            Assert.AreEqual(c, dbCity.Get(9999));


            
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

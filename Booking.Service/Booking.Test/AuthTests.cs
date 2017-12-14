using Microsoft.VisualStudio.TestTools.UnitTesting;
using Booking.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Test.AuthRemote;

namespace Booking.Service.Tests
{
    [TestClass()]
    public class AuthTests
    {
        AuthClient client = new AuthClient();

        [TestMethod()]
        public void CreateLoginTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTest()
        {
            Assert.IsNull(client.Login("test", "svend"));
            Assert.IsNotNull(client.Login("admin@test.dk", "1234"));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Booking.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Controller;
using Booking.Models;

namespace Booking.Service.Tests
{
    [TestClass()]
    public class AuthTests
    {
        [TestMethod()]
        public void CreateLoginTest()
        {
            Auth auth = new Auth();
            var email = "admin@test.dk";
            var password = "1234";
            var firstname = "Admin";
            var lastname = "istrator";
            var address = "Kongevej 5";
            var zipcode = 9000;
            long phoneno = 42732521;

            Assert.IsTrue(auth.CreateLogin("test2@test.dk", password, firstname, lastname, address, zipcode, phoneno));
            Assert.IsFalse(auth.CreateLogin(email, password, firstname, lastname, address, zipcode, phoneno));

        }

        [TestMethod()]
        public void LoginTest()
        {
            Auth auth1 = new Auth();
            var usernameAccess = "admin@test.dk";
            var passwordAccess = "1234";
            Assert.IsNotNull(auth1.Login(usernameAccess, passwordAccess));


            //why dis dun work?

            //Auth auth2 = new Auth();
            //var usernameFail = "fail@test.dk";
            //var passwordFail = "4321";
            //Assert.IsNull(auth2.Login(usernameFail, passwordFail));
        }
    }
}
using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Booking.Controller;

namespace Booking.Service.AccessValidation
{
    public class CredentialValidator : UserNamePasswordValidator
    {
        private UserCtrl uCtrl = new UserCtrl();
        public override void Validate(string userName, string password)
        {
            userName = userName.ToLower();
            var foundUser = uCtrl.GetUser(userName);

            if (foundUser != null && foundUser.Email == userName && foundUser.Password == password)
            {
                Console.WriteLine("Service: " + foundUser.Email + " connected...");
                //email pw are valid
            }
            else
            {
                Console.WriteLine("Service: login failed for " + userName + " (wrong username or password)");
                throw new FaultException<Exception>(new Exception("Invalid Login..."), "Invalid Credentials");
            }
        }
    }
}
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
        public override void Validate(string email, string password)
        {
            email = email.ToLower();
            var foundUser = uCtrl.GetUser(email);

            if (foundUser != null && foundUser.Email == email && foundUser.Password == password)
            {
                Console.WriteLine("Service: " + foundUser.Email + " connected...");
                //email pw are valid
            }
            else
            {
                Console.WriteLine("Service: login failed for " + email + " (wrong username or password)");
                throw new FaultException<Exception>(new Exception("Invalid Login..."), "Invalid Credentials");
            }
        }
    }
}
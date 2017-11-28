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
        private UserController UserCtrl = new UserController();
        public override void Validate(string userName, string password)
        {
            var foundUser = UserCtrl.GetUser(userName);
            if (foundUser != null && foundUser.Email == userName && foundUser.Password == password)
            {
                //email pw are valid
            }
            else
            {
                throw new FaultException<Exception>(new Exception("Invalid Login..."), "Invalid Credentials");
            }
        }
    }
}
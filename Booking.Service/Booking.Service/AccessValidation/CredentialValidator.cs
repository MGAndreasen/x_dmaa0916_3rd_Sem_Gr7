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
            if (OperationContext.Current.EndpointDispatcher.ContractName != "IMetadataExchange")
            {
                var foundUser = uCtrl.GetUser(userName);

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
}
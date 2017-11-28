using Booking.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Service.AccessValidation
{
    public class RoleValidator : ServiceAuthorizationManager
    {
        private UserCtrl uCtrl = new UserCtrl();
        protected override bool CheckAccessCore(OperationContext operationContext)
        {
            //Get the current pipeline user context
            var identity = operationContext.ServiceSecurityContext.PrimaryIdentity;
            //simulate that we get a user and all his roles from the database

            var userFound = uCtrl.GetUser(identity.Name);
            
            if (userFound == null)
            {
                //throw new Exception("User not found");

                return false;
            }
            else
            {
                string[] userRolesFound = userFound.Roles.Select(x => x.Name).ToArray();
                //Assign roles to the Principal property for runtime to match with PrincipalPermissionAttributes decorated on the service operation.
                var principal = new GenericPrincipal(operationContext.ServiceSecurityContext.PrimaryIdentity, userRolesFound);
                //assign principal to auth context with the users roles
                operationContext.ServiceSecurityContext.AuthorizationContext.Properties["Principal"] = principal;
                //return true if all goes well
                return true;
            }
        }
    }
}
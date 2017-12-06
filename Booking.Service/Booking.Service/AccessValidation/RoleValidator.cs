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
            var userFound = uCtrl.GetUser(identity.Name);

            if (operationContext.EndpointDispatcher.ContractName == "IMetadataExchange")
            {
                string[] userRolesFound = { "Guest" };
                var principal = new GenericPrincipal(operationContext.ServiceSecurityContext.PrimaryIdentity, userRolesFound);
                operationContext.ServiceSecurityContext.AuthorizationContext.Properties["Principal"] = principal;
                return true;
            }
            else if (userFound != null)
            {
                string[] userRolesFound = userFound.Roles.Select(x => x.Name).ToArray();

                //Assign roles to the Principal property for runtime to match with PrincipalPermissionAttributes decorated on the service operation.
                var principal = new GenericPrincipal(operationContext.ServiceSecurityContext.PrimaryIdentity, userRolesFound);

                //assign principal to auth context with the users roles
                operationContext.ServiceSecurityContext.AuthorizationContext.Properties["Principal"] = principal;

                //return true if all goes well
                return true;
            }
            else
            {
                Console.WriteLine("Service: User unknown!");
                throw new FaultException("User not found");
            }
        }
    }
}
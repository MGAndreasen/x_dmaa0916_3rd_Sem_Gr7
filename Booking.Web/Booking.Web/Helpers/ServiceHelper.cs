using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Booking.Web.BookingAuthRemote;
using Booking.Web.BookingServiceRemote;

namespace Booking.Web.Helpers
{
    public class ServiceHelper
    {
            public static ServiceClient GetServiceClientWithCredentials(string username, string password)
            {
                ServiceClient client = new ServiceClient("WSHttpBinding_IService");
                client.ClientCredentials.UserName.UserName = username;
                client.ClientCredentials.UserName.Password = password;
                return client;
            }

            public static AuthClient GetAuthServiceClient()
            {
                return new AuthClient("WSHttpBinding_IAuth");
            }
    }
}
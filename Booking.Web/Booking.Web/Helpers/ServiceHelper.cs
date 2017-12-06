using Booking.Web.BookingAuthRemote;
using Booking.Web.BookingServiceRemote;

namespace Booking.Web.Helpers
{
    public class ServiceHelper
    {
        public static ServiceClient GetServiceClientWithCredentials()
        {
            string username = "guest";
            string password = "guest";

            if (AuthHelper.IsLoggedIn())
            {
                    username = AuthHelper.CurrentUser.Email.ToLower();
                    password = AuthHelper.CurrentUser.Password;
            }

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
using Booking.Controller;
using Booking.Models;

namespace Booking.Service
{
    public class Auth : IAuth
    {
        private UserCtrl uCtrl = new UserCtrl();

        public User Login(string username, string password)
        {
            User user = uCtrl.GetUser(username);
            return user;
        }
    }
}

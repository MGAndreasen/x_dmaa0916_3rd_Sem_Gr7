using Booking.Controller;

namespace Booking.Service
{
    public class Auth : IAuth
    {
        private UserCtrl uCtrl = new UserCtrl();

        public bool Login(string username, string password)
        {
            var user = uCtrl.GetUser(username);
            return user.Email == username && user.Password == password;
        }
    }
}

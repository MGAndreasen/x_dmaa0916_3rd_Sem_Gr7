using Booking.Controller;

namespace Booking.Service
{
    public class Auth : IAuth
    {
        private UserController UserCtrl = new UserController();

        public bool Login(string username, string password)
        {
            var user = UserCtrl.GetUser(username);
            return user.Email == username && user.Password == password;
        }
    }
}

// Using statements
using Booking.Controller;
using Booking.Models;
using System.ServiceModel;

// Vores namespace
namespace Booking.Service
{
    // Setter WCF til at køre vores service som PerCall (), og med ConcurrencyMode Multiple (Threading)
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]

    // Auth class der implementere vores IAuth interface
    public class Auth : IAuth
    {
        // Ny instance af UserCtrl()
        private UserCtrl uCtrl = new UserCtrl();
        private CustomerCtrl cCtrl = new CustomerCtrl();

        // Login methode (retunering af User obj)
        public User Login(string username, string password)
        {
            // Forsøg at finde Useren med brugernavn
            User user = uCtrl.GetUser(username);

            // Tjek at der faktisk blev retuneret en bruger
            if (user != null)
            {
                // Tjek om brugerens password matcher det tilsendte fra klienten
                if (user.Password.ToString() == password)
                {
                    // Hvis match,

                    // Så log, og


                    //retuner User objected
                    return user;
                }
            }

            // Fall thrue, return null hvis det tidligere ikke lykkes.
            return null;
        }
    }
}
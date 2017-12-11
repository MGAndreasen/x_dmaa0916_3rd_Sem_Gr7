// Using statements
using System;
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
        public Customer Login(string email, string password)
        {
            // Tjaa....
            email = email.ToLower();

            // Forsøg at finde Useren med brugernavn
            var user = uCtrl.GetUser(email);

            // Tjek at der faktisk blev retuneret en bruger
            if (user != null)
            {
                // Tjek om brugerens password matcher det tilsendte fra klienten
                if (user.Password.ToString() == password)
                {
                    // Hvis match,

                    // Så log, og
                    Console.WriteLine("AuthService: user " + user.Email + " just authed!");

                    //retuner User objected
                    return user;
                }

                Console.WriteLine("AuthService: password for " + user.Email + " not correct!");
                return null;
            }

            Console.WriteLine("AuthService: " + user.Email + " not found!");
            // Fall thrue, return null hvis det tidligere ikke lykkes.
            return null;
        }
    }
}
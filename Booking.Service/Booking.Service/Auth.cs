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
        //private CustomerCtrl cCtrl = new CustomerCtrl();
        private CityCtrl cityCtrl = new CityCtrl();


        public bool CreateLogin(string email, string password, string firstname, string lastname, string address, int zipcode, long phonenumber)
        {
            bool lykkes = false;

            email = email.ToString().Trim().ToLower();
            password = password.Trim();
            firstname = firstname.Trim();
            lastname = lastname.Trim();
            address = address.Trim();

            if (email.Length >= 6 && password.Length >= 4 && firstname.Length >= 2 && lastname.Length >= 2 && address.Length >= 4 && zipcode > 999 && phonenumber > 0)
            {
                if (email.Contains("@") && email.Contains("."))
                {
                    User exists = uCtrl.GetUser(email);

                    if (exists == null)
                    {
                        Customer c = new Customer();
                        c.Email = email;
                        c.Password = password;
                        c.FirstName = firstname;
                        c.LastName = lastname;
                        c.Address = address;
                        c.City = cityCtrl.Get(zipcode);
                        c.Role = "User";
                        c.CPR = 0000000000;
                        c.Confirmed = false;

                        if (uCtrl.CreateUser(c))
                        {
                            lykkes = true;
                        }
                    }
                    else if (exists != null)
                    {
                        lykkes = false;
                    }
                }
            }
            return lykkes;
        }

        //private CustomerCtrl cCtrl = new CustomerCtrl();

        // Login methode (retunering af User obj)
        public User Login(string email, string password)
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
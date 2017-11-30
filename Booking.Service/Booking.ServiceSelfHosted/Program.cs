using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Service;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Security.Cryptography.X509Certificates;

namespace Booking.ServiceSelfHosted
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will host both wsHttp and netTcp bindings of secureservice
            ServiceHost host = new ServiceHost(typeof(Booking.Service.Service));

            //This will host both wsHttp and netTcp bindings of authservice
            ServiceHost authhost = new ServiceHost(typeof(Booking.Service.Auth));

            host.Open();
            Console.WriteLine("SecureService host is running...");
            authhost.Open();
            Console.WriteLine("AuthService is running");
            Console.ReadLine();
            host.Close();
            authhost.Close();
        }
    }
}

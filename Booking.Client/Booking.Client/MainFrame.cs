using Booking.Client.BookingServiceRemote;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Booking.Client.UserControls;

namespace Booking.Client
{
    public partial class MainFrame : Form
    {
        ServiceClient myService = new ServiceClient();
        BookingAuthRemote.User currentUser = null;
        public MainFrame(BookingAuthRemote.User curUser)
        {
            InitializeComponent();

            bool demoData = false; // For at lave demo data.

            //Tilføjer UserControl til hver tab.
            tabPagePassengers.Controls.Add(new PassengersControl(curUser));
            tabPageDeparture.Controls.Add(new DepartureControl(curUser));
            tabPage1.Controls.Add(new PlaneControl(curUser));
            tabPageBookings.Controls.Add(new BookingControl(curUser));
            tabCreateRoute.Controls.Add(new DestinationControl(curUser));

            //Login
            currentUser = curUser;
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            myService.ClientCredentials.UserName.UserName = currentUser.Email;
            myService.ClientCredentials.UserName.Password = currentUser.Password;

            //Create Demo departure data
            if (demoData)
            {
                // Init vores randomizer
                Random rnd = new Random();

                // Hent alle Destinationer
                var allDestinations = myService.GetAllDestinations();

                // Hent alle PlaneTyper
                var allPlaneTypes = myService.GetAllPlanes();

                //Kun for Aalborg og Retur...
                var startdest = allDestinations.Find(x => x.NameDestination == "Aalborg");
                var enddest = allDestinations.Find(x => x.NameDestination == "Oslo");

                var d = new Departure
                {
                    StartDestination = startdest,
                    EndDestination = enddest,
                    DepartureTime = Convert.ToDateTime("13/01/2018 22:25:00"),
                    Plane = allPlaneTypes[rnd.Next(0, allPlaneTypes.Count)]
                };
                myService.CreateDepartureAsync(d);


                var r = new Departure
                {
                    StartDestination = enddest,
                    EndDestination = startdest,
                    DepartureTime = Convert.ToDateTime("14/01/2018 18:45:00"),
                    Plane = allPlaneTypes[rnd.Next(0, allPlaneTypes.Count)]
                };
                myService.CreateDepartureAsync(r);

                // For hver destination
                //foreach (var startdest in allDestinations)
                //{
                //foreach (var enddest in allDestinations)
                //    {
                //        if (startdest.Id == enddest.Id)
                //        {
                //            continue;
                //        }
                //        else
                //        {
                //            for (int i = 1; i < DateTime.DaysInMonth(2018, 01); i++)
                //            {
                //                var d = new Departure
                //                {
                //                    StartDestination = startdest,
                //                    EndDestination = enddest,
                //                    DepartureTime = Convert.ToDateTime(i.ToString() + "/01/2018 "+rnd.Next(00,23) + ":"+rnd.Next(00,59)),
                //                    Plane = allPlaneTypes[rnd.Next(0, allPlaneTypes.Count)]
                //                };

                //                myService.CreateDepartureAsync(d);
                //            }

                //        for (int i = 1; i < DateTime.DaysInMonth(2018, 01); i++)
                //        {
                //            var d = new Departure
                //            {
                //                StartDestination = enddest,
                //                EndDestination = startdest,
                //                DepartureTime = Convert.ToDateTime(i.ToString() + "/01/2018 " + rnd.Next(00, 23) + ":" + rnd.Next(00, 59)),
                //                Plane = allPlaneTypes[rnd.Next(0, allPlaneTypes.Count)]
                //            };

                //            myService.CreateDepartureAsync(d);
                //        }
                //    }
                //    }
                //}
            }
        }
    }
}
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


        }
    }
}
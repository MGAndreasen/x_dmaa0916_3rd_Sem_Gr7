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

        PassengersControl pc;
        DepartureControl dec;
        PlaneControl plc;
        BookingsControl bc;
        DestinationControl dc;

        TabPage passenger;

        public MainFrame(BookingAuthRemote.User curUser)
        {
            InitializeComponent();

            pc = new PassengersControl(curUser);
            dec = new DepartureControl(curUser);
            plc = new PlaneControl(curUser);
            bc = new BookingsControl(curUser);
            dc = new DestinationControl(curUser);

            //Tilføjer UserControl til hver tab.
            passenger = tabPagePassengers;
            passenger.Controls.Add(dc);
            tabPageDeparture.Controls.Add(dec);
            tabPage1.Controls.Add(plc);
            tabPageBookings.Controls.Add(bc);
            tabCreateRoute.Controls.Add(dc);

            //Login
            currentUser = curUser;
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            myService.ClientCredentials.UserName.UserName = currentUser.Email;
            myService.ClientCredentials.UserName.Password = currentUser.Password;


        }

        private void PlaneTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach(var tab in PlaneTab.Controls)
            //{
                
            //}
        }
    }
}
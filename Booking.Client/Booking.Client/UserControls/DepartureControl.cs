using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booking.Client.BookingServiceRemote;
using System.Net;

namespace Booking.Client.UserControls
{
    public partial class DepartureControl : UserControl
    {
        ServiceClient myService = new ServiceClient();
        BookingAuthRemote.User currentUser = null;

        public DepartureControl(BookingAuthRemote.User curUser)
        {
            InitializeComponent();

            currentUser = curUser;
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            myService.ClientCredentials.UserName.UserName = currentUser.Email;
            myService.ClientCredentials.UserName.Password = currentUser.Password;

        }

        private void Departure_CreateDepartureBtn_Click(object sender, EventArgs e)
        {
            if (Departure_ListDestinations.SelectedItem != null && calenderRoute.SelectionStart != null && comboBoxDepartures_ListOfPlanes.SelectedItem != null)
            {
                try
                {
                    var d = new Departure
                    {
                        StartDestination = myService.GetDestination(5),
                        EndDestination = (Destination)Departure_ListDestinations.SelectedItem,
                        DepartureTime = calenderRoute.SelectionStart,
                        Plane = (Plane)comboBoxDepartures_ListOfPlanes.SelectedItem
                    };

                    myService.CreateDeparture(d);
                }
                catch (Exception)
                { }
            }
        }

        private void Departure_DeleteDepartureBtn_Click(object sender, EventArgs e)
        {
            Departure d = null;
            try
            {
                d = (Departure)Departure_ListDespartures.SelectedItem;
            }
            catch (Exception) { }

            if (d != null)
            {
                myService.DeleteDeparture(d.Id);
            }
        }

        private void Departure_RefreshDepartureBtn_Click(object sender, EventArgs e)
        {
            Departure_ListDespartures.Items.Clear();

            Departure_ListDespartures.DataSource = myService.GetAllDepartures();
            Departure_ListDespartures.ValueMember = "Id";
            Departure_ListDespartures.DisplayMember = "Id";
        }

        private void LoadPlanes_Click(object sender, EventArgs e)
        {
            comboBoxDepartures_ListOfPlanes.DataSource = myService.GetAllPlanes();
            comboBoxDepartures_ListOfPlanes.ValueMember = "Id";
            comboBoxDepartures_ListOfPlanes.DisplayMember = "Type";
        }

        private void Departure_RefreshDestinationsBtn_Click(object sender, EventArgs e)
        {
            Departure_ListDestinations.Items.Clear();
            Departure_ListDestinations.DataSource = myService.GetAllDestinations();
            Departure_ListDestinations.ValueMember = "Id";
            Departure_ListDestinations.DisplayMember = "NameDestination";
        }
    }
}

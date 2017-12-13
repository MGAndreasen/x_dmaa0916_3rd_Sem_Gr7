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
    public partial class PassengersControl : UserControl
    {
        ServiceClient myService = new ServiceClient();
        BookingAuthRemote.User currentUser = null;
        public PassengersControl(BookingAuthRemote.User curUser)
        {
            InitializeComponent();

            currentUser = curUser;
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            myService.ClientCredentials.UserName.UserName = currentUser.Email;
            myService.ClientCredentials.UserName.Password = currentUser.Password;

        }

        public void FillInfoBooking()
        {
            var b = (Bookings)listBoxListOfBookings.SelectedItem;
            textBox__Bookings_Customer.Text = b.Customer.FirstName.ToString();

            foreach (Passenger p in myService.GetAllPassengers())
            {
                if (p.Booking.Id == b.Id)
                {
                    comboBox__Bookings_Passengers.DataSource = myService.GetAllPassengers();
                }
            }
            comboBox__Bookings_Passengers.ValueMember = "Id";
            comboBox__Bookings_Passengers.DisplayMember = "FirstName";
        }

        private void comboBox__Bookings_Passengers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pa = (Passenger)comboBox__Bookings_Passengers.SelectedItem;

            textBox_Bookings_Passenger_FirstName.Text = pa.FirstName.ToString();
            textBox__Bookings_Passenger_LastName.Text = pa.LastName.ToString();
            textBox__Bookings_Passenger_CPR.Text = pa.CPR.ToString();
            textBox__Bookings_Passenger_PassportNo.Text = pa.PassportId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxListOfBookings.Items.Clear();
            listBoxListOfBookings.DataSource = myService.GetAllBookings();
            listBoxListOfBookings.ValueMember = "Id";
            listBoxListOfBookings.DisplayMember = "Customer_Id";
        }
    }
}

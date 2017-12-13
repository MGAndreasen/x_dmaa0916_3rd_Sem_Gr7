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
using Booking.Client.BookingAuthRemote;
using System.Net;

namespace Booking.Client.UserControls
{
    public partial class BookingControl : UserControl
    {
        ServiceClient myService = new ServiceClient();
        BookingAuthRemote.User currentUser = null;

        public BookingControl(BookingAuthRemote.User curUser)
        {
            InitializeComponent();

            currentUser = curUser;
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            myService.ClientCredentials.UserName.UserName = currentUser.Email;
            myService.ClientCredentials.UserName.Password = currentUser.Password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxDepartures.DataSource = myService.GetAllDepartures();
            listBoxDepartures.ValueMember = "Id";
            listBoxDepartures.DisplayMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxCustomers.DataSource = myService.GetAllCustomers();
            listBoxCustomers.ValueMember = "Id";
            listBoxCustomers.DisplayMember = "FirstName";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = myService.GetAllBookings();
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Id";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var b = (Bookings)listBox1.SelectedItem;

            myService.DeleteBooking(b.Id);
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9\b]"))
            {
                e.Handled = true;
            }
        }
    }
}

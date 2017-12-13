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

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxPassengers_Planes.Items.Clear();
            comboBoxPassengers_Planes.DataSource = myService.GetAllPlanes();
            comboBoxPassengers_Planes.ValueMember = "Id";
            comboBoxPassengers_Planes.DisplayMember = "Type";
        }
    }
}

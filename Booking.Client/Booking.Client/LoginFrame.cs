using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booking.Client.BookingAuthRemote;
using Booking.Client.BookingServiceRemote;
using System.ServiceModel.Security;

namespace Booking.Client
{
    public partial class LoginFrame : Form
    {
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AuthClient authClient = new AuthClient();
            ServiceClient serviceClient = new ServiceClient();
        //    authClient.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;

            serviceClient.ClientCredentials.UserName.UserName = "admin@test.dk";
            serviceClient.ClientCredentials.UserName.Password = "1234";

            if (textBox1.Text == serviceClient.ClientCredentials.UserName.UserName && textBox2.Text == serviceClient.ClientCredentials.UserName.Password)
            {
            this.Hide();
            MainFrame MF = new MainFrame();
            MF.ShowDialog();
            this.Close();
              }
            else
            {
              
            }

        }

    }
   }


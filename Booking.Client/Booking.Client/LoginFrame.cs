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

            //AuthClient authClient = new AuthClient();
            //ServiceClient serviceClient = new ServiceClient();
            //authClient.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;

            //authClient.ClientCredentials.UserName.UserName = "Hej";
            //authClient.ClientCredentials.UserName.Password = "Du";

            //if (textBox1.Text == authClient.ClientCredentials.UserName.UserName && textBox2.Text == authClient.ClientCredentials.UserName.Password)
            //{
            //    this.Hide();
            //    MainFrame MF = new MainFrame();
            //    MF.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong Password!");
            //}

            //if (textBox1.Text == "Bush" && textBox2.Text == "Did911")
            //{
            //    Hides LoginFrame(The main applicantion)
            //    this.Hide();

            //    Starts a new window
            //    MainFrame MF = new MainFrame();
            //    MF.ShowDialog();

            //    Closes the LoginFrame after the other window has opened.
            //    this.Close();
            //}
            //else
            //{
            //    Cheat
            //}



        }

    }
}

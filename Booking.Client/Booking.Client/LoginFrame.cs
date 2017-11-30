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
using System.Net;

namespace Booking.Client
{
    public partial class LoginFrame : Form
    {
        AuthClient authClient = new AuthClient();
        ServiceClient serviceClient = new ServiceClient();
        Boolean isLoggedin = false;

        public LoginFrame()
        {
            InitializeComponent();
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //authClient.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;

            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;


            isLoggedin = authClient.Login(textBox1.Text.ToString().Trim(), textBox2.Text.ToString().Trim());

            if (isLoggedin)
            {
                MessageBox.Show("Uha uha da da!");

                serviceClient.ClientCredentials.UserName.UserName = textBox1.Text.ToString().Trim();
                serviceClient.ClientCredentials.UserName.Password = textBox2.Text.ToString().Trim();

                

                MessageBox.Show(serviceClient.GetCity(9000).CityName.ToString());
            }
            else
            {
                MessageBox.Show("Faaack IT!");
            }


            

            

            //if (textBox1.Text == serviceClient.ClientCredentials.UserName.UserName && textBox2.Text == serviceClient.ClientCredentials.UserName.Password)
            //{
            //    this.Hide();
            //    MainFrame MF = new MainFrame();
            //    MF.ShowDialog();
            //    this.Close();
            //}
            //else
            //{

            //}

        }

    }
   }


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

        BookingAuthRemote.User isLoggedin = null;

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

            try
            {
                isLoggedin = authClient.Login(textBox1.Text.ToString().Trim(), textBox2.Text.ToString().Trim());

                if (isLoggedin != null)
                {
                    serviceClient.ClientCredentials.UserName.UserName = isLoggedin.Email.ToString();
                    serviceClient.ClientCredentials.UserName.Password = isLoggedin.Password.ToString();

                    this.Hide();
                    MainFrame MF = new MainFrame();
                    MF.ShowDialog();
                    this.Close();
                }
                else
                {
                   // MessageBox.Show("Brugernavn eller adgangskode ikke korrekt!");
                }
            }
            catch (Exception)
            {
                
                //throw new Exception("Brugernavn eller adgangskode ikke korrekt!");
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


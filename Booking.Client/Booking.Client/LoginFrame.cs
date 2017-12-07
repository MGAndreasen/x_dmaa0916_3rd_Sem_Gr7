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
            if (textBox1.Text.ToString().Trim() == "" || textBox2.Text.ToString().Trim() == "")
            {
                string fejl = "";

                if (textBox1.Text.ToString().Trim() == "")
                {
                    // Brugernavn må ikke være blankt!
                    fejl += "Brugernavn";
                }

                if (textBox2.Text.ToString().Trim() == "")
                {
                    // Password må ikke være blankt!
                    fejl += (fejl.Length > 0 ? " og Password" : "Password");
                }

                lblStatus.Text = fejl + " må ikke være blankt!";
            }
            else
            {

                try
                {
                    isLoggedin = authClient.Login(textBox1.Text.ToString().Trim(), textBox2.Text.ToString().Trim());

                    if (isLoggedin != null)
                    {
                        lblStatus.Text = "";

                        if (isLoggedin.Roles.First().Name.ToString().ToLower() == "admin")
                        {
                            serviceClient.ClientCredentials.UserName.UserName = isLoggedin.Email.ToString();
                            serviceClient.ClientCredentials.UserName.Password = isLoggedin.Password.ToString();

                            this.Hide();
                            MainFrame MF = new MainFrame();
                            MF.ShowDialog();
                            //this.Close();
                        }
                        else
                        {
                            lblStatus.Text = "Kun Administratore kan logge ind her!";
                            isLoggedin = null;
                        }
                    }
                    else
                    {
                        lblStatus.Text = "Brugernavn eller Password var forkert!";
                    }
                }
                catch (Exception)
                {
                    lblStatus.Text = "Der er sket en fejl!";
                    //throw new Exception("Brugernavn eller adgangskode ikke korrekt!");
                }
            }

        }

    }
}


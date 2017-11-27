using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Hides LoginFrame (The main applicantion)
            this.Hide();

            //Starts a new window
            MainFrame MF = new MainFrame();
            MF.ShowDialog();

            //Closes the LoginFrame after the other window has opened. 
            this.Close();


            
        }

    }
}

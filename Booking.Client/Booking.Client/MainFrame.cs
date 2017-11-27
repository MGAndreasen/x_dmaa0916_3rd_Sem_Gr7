using Booking.Client.BookingServiceRemote;
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
    public partial class MainFrame : Form
    {  
        public MainFrame()
        {
            InitializeComponent();
            VisPassager();
        }

        public void VisPassager()
        {
            ServiceClient myService = new ServiceClient();
            Passenger p = myService.GetPassenger(1);
            listBoxPlanes.Items.Add(p.ToString());
        }

        public void VisPassagers()
        {
          //  ServiceClient client = new ServiceClient();
           // Passenger p = client.GetPassenger(1);
            // listView1.Items.Add(p.ToString());
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
                
        }

        private void MainFrame_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

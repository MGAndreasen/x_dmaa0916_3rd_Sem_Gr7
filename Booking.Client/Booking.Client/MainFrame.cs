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
        ServiceClient myService = new ServiceClient();
        public MainFrame()
        {
            InitializeComponent();
        }

        public void VisPassager()
        {
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxPassengers_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Plane> list = myService.getAllPlanes();
            foreach (var item in list)
            {
                comboBoxPassengers_Planes.Items.Add(item.ToString());
            }
        }

        private void ComboBoxSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Plane> list = myService.getAllPlanes();
            foreach (var item in list)
            {
                comboBoxSeats_ListOfPlanes.Items.Add(item.ToString());
            }
        }

        public void TapSeat_ShowPassengersOnPlane()
        {
            
        }

        private void ComboBoxDestination_ListOfPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Plane> list = myService.getAllPlanes();
            foreach (var item in list)
            {
                comboBoxDestination_ListOfPlanes.Items.Add(item.ToString());
            }
        }
    }
}

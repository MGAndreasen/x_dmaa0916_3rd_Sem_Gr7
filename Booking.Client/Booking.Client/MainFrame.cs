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
            VisPassager();
        }

        public void VisPassager()
        {
           // City c = myService.GetCity(9000);
           // listBoxPassengers.Items.Add(c.ToString());
        }

        public void VisPassagers()
        {
            //ServiceClient client = new ServiceClient();
            //Passenger p = client.GetPassenger(1);
            //listView1.Items.Add(p.ToString());
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
            List<Plane> list = myService.GetAllPlanes();
            foreach (var item in list)
            {
                comboBoxPassengers_Planes.Items.Add(item.ToString());
            }
        }

        private void ComboBoxSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Plane> list = myService.GetAllPlanes();
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
            List<Plane> list = myService.GetAllPlanes();
            foreach (var item in list)
            {
                comboBoxDestination_ListOfPlanes.Items.Add(item.ToString());
            }
        }
        private void DestinationCreate_Click(object sender, EventArgs e)
        {

            Destination DS = new Destination();

            CreateDestinationRequest request = new CreateDestinationRequest(DS);

            myService.CreateDestination(request);

            // City c = myService.GetCity(9000);
            // listBoxPassengers.Items.Add(c.ToString

        }  

        private void RefreshDestinations_Click(object sender, EventArgs e)
        {
            List<Destination> list = myService.GetAllDestinations();
            foreach (var item in list)
            {
                listBoxPlanes.Items.Add(item.ToString());
            }
        }

        private void CreateRoute_monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxDateTime.Text = CreateRoute_monthCalendar.SelectionRange.Start.ToShortDateString();
        }

        private void tabCreateRoute_Click(object sender, EventArgs e)
        {

        }

        private void CreateRoute_StartDestination_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

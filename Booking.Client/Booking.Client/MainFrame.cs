using Booking.Client.BookingServiceRemote;
using Booking.Client.BookingAuthRemote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; 
using System.ServiceModel.Security;

namespace Booking.Client
{
    public partial class MainFrame : Form
    {
        ServiceClient myService = new ServiceClient();


        public MainFrame()
        {
            InitializeComponent();
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            // VisPassager();
        }

        public void VisPassager()
        {
            //var request = new GetBookingRequest();

            //myService.GetBooking()

            City c = myService.GetCity(9000);
            listBoxPassengers.Items.Add(c.ToString());
        }

        public void VisPassagers()
        {
            ServiceClient client = new ServiceClient();
            Passenger p = client.GetPassenger(1);
            listBoxPassengers.Items.Add(p.ToString());
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
            //List<Plane> list = myService.GetAllPlanes();
            //foreach (var item in list)
            //{
            //    comboBoxPassengers_Planes.Items.Add(item.ToString());
            //}
        }

        private void ComboBoxSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Plane> list = myService.GetAllPlanes();
            //foreach (var item in list)
            //{
            //    comboBoxSeats_ListOfPlanes.Items.Add(item.ToString());
            //}
        }

        public void TapSeat_ShowPassengersOnPlane()
        {
            
        }

        private void ComboBoxDestination_ListOfPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Plane> list = myService.GetAllPlanes();
            //foreach (var item in list)
            //{
            //    comboBoxDestination_ListOfPlanes.Items.Add(item.ToString());
            //}
        }
        private void DestinationCreate_Click(object sender, EventArgs e)
        {
            string text = CreateRoute_StartDestination.Text;
            Destination d = new Destination();
            text.Equals(d);

            myService.CreateDestination(d);
        }  

        private void RefreshDestinations_Click(object sender, EventArgs e)
        {
            //List<Destination> list = myService.GetAllDestinations();
            //foreach (var item in list)
            //{
            //    listBoxPlanes.Items.Add(item.ToString());
            //}
        }

        private void CreateRoute_monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxDateTime.Text = CreateRoute_monthCalendar.SelectionRange.Start.ToShortDateString();
            CreateRoute_monthCalendar.MaxDate = DateTime.Now;
            
        }

        private void tabCreateRoute_Click(object sender, EventArgs e)
        {

        }
    }
}

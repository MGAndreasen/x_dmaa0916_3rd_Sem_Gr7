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
            myService.ClientCredentials.UserName.UserName = "admin@test.dk";
            myService.ClientCredentials.UserName.Password = "1234";
            ShowPassager();
            ShowPlanesComboBox();
            ShowDestinations();
            
        }

        public void ShowPassager()
        {
            var c = myService.GetCity(9000);
            var n = myService.GetPassenger(1);
            listBoxPassengers.Items.Add(n.FirstName+"," +n.LastName+ "," + c.Zipcode + "," + c.CityName);
        }

        public void ShowPlanesComboBox()
        {
            comboBoxDestination_ListOfPlanes.DataSource = myService.GetAllPlanes();
            comboBoxDestination_ListOfPlanes.ValueMember = "Id";
            comboBoxDestination_ListOfPlanes.DisplayMember = "Type";
        }

        public void ShowDestinations()
        {
            List<Destination> list = myService.GetAllDestinations();
            listBoxPlanes.Items.Clear();
            foreach (var item in list)
            {
                listBoxPlanes.Items.Add(item.NameDestination + "," + item.Plane.Type);
            }
        }

      //  public void DeleteDestination()
       // {
        //    listBoxPlanes.SelectedItems
       // }
        public void CreateDestination()
        {

            var p = (Plane)comboBoxDestination_ListOfPlanes.SelectedItem;
            Destination d = new Destination
            {
                NameDestination = CreateRoute_StartDestination.Text.ToString(),
                Plane = myService.GetPlane(p.Id)
            };

            myService.CreateDestination(d);
            CreateRoute_StartDestination.Clear();

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

        private void RefreshDestinations_Click(object sender, EventArgs e)
        {
            listBoxPlanes.Items.Clear();
            ShowDestinations();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            CreateDestination();
        }

        private void DeleteRoute_Button_Click(object sender, EventArgs e)
        {

        }
    }
}

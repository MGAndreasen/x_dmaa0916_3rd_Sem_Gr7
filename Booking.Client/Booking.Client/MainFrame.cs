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
using System.Text.RegularExpressions;

namespace Booking.Client
{
    public partial class MainFrame : Form
    {
        ServiceClient myService = new ServiceClient();
        List<Tuple<Destination, DateTime>> routes = new List<Tuple<Destination, DateTime>>();
        BookingAuthRemote.User currentUser = null;

        public MainFrame(BookingAuthRemote.User curUser)
        {
            InitializeComponent();
            Plane_RowNumber.ContextMenu = new ContextMenu();
            Plane_SeatSchemaTextBox.ContextMenu = new ContextMenu();
            currentUser = curUser;
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            myService.ClientCredentials.UserName.UserName = currentUser.Email;
            myService.ClientCredentials.UserName.Password = currentUser.Password;
            ShowPassager();
            ShowPlanesComboBox();
            ShowDestinations();
            ShowBookings();
            FillInfoBooking();
            ShowSeatSchema();
        }

        public void ShowPassager()
        {
            var c = myService.GetCity(9000);
            var n = myService.GetPassenger(1);
            listBoxPassengers.Items.Add(n.FirstName + "," + n.LastName + "," + c.Zipcode + "," + c.CityName);
        }
        public void ShowSeatSchema()
        {
            //MainFrame, Planetab
            Plane_SeatSchema.ValueMember = "Id";
            Plane_SeatSchema.DisplayMember = "Row";
        }
        public void ShowPlanesComboBox()
        {
            //MainFrame, Destinaion
            comboBoxDestination_ListOfPlanes.DataSource = myService.GetAllPlanes();
            comboBoxDestination_ListOfPlanes.ValueMember = "Id";
            comboBoxDestination_ListOfPlanes.DisplayMember = "Type";

            //Mainframe, Seats
            comboBoxSeats_ListOfPlanes.DataSource = myService.GetAllPlanes();
            comboBoxSeats_ListOfPlanes.ValueMember = "Id";
            comboBoxSeats_ListOfPlanes.DisplayMember = "Type";

            //Mainframe, Passenger
            comboBoxPassengers_Planes.DataSource = myService.GetAllPlanes();
            comboBoxPassengers_Planes.ValueMember = "Id";
            comboBoxPassengers_Planes.DisplayMember = "Type";

        }

        public void ShowBookings()
        {
            listBoxListOfBookings.DataSource = myService.GetAllBookings();
            listBoxListOfBookings.ValueMember = "Id";
            listBoxListOfBookings.DisplayMember = "Customer_Id";
        }

        public void FillInfoBooking()
        {
            var b = (Bookings)listBoxListOfBookings.SelectedItem;
            //textBox_Bookings_StartDestination.Text = b.StartDestination.NameDestination.ToString();
            //textBox_Bookings_EndDestination.Text = b.EndDestination.NameDestination.ToString();
            //textBox_Bookings_Plane.Text = b.EndDestination.Plane.Id.ToString();
            textBox__Bookings_Customer.Text = b.Customer.FirstName.ToString();

            foreach (Passenger p in myService.GetAllPassengers())
            {
                if (p.Booking.Id == b.Id)
                {
                    comboBox__Bookings_Passengers.DataSource = myService.GetAllPassengers();
                }
            }
            comboBox__Bookings_Passengers.ValueMember = "Id";
            comboBox__Bookings_Passengers.DisplayMember = "FirstName";
        }

        public void CreateRoute()
        {
            DateTime date = calenderRoute.SelectionRange.Start;
            var d = (Destination)destBox.SelectedItem;
            Departure de = new Departure();
            {

                d = de.EndDestination;
                date = de.DepartureTime;
                //   d.Plane = de.PlaneId;

            }
            myService.CreateDeparture(de);
        }

        public void CreateSeatSchema()
        {
            var layout = Plane_SeatSchema.Text.ToString();
            var rownum = Int32.Parse(Plane_RowNumber.Text.ToString());

            Plane plane = (Plane)Plane_PlaneBox.SelectedItem;

            SeatSchema schema = new SeatSchema { Layout = layout, Row = rownum };

            plane.SeatSchema.Add(schema);

            myService.UpdatePlane(plane);

            ShowPlanes();
        }


        public void ShowPlanes()
        {
            Plane_SeatSchema.Items.Clear();
            Plane_PlaneBox.DataSource = myService.GetAllPlanes();
            Plane_PlaneBox.ValueMember = "Id";
            Plane_PlaneBox.DisplayMember = "Type";
        }
        public void ShowDestinations()
        {
            listBoxPlanes.DataSource = myService.GetAllDestinations();
            listBoxPlanes.ValueMember = "Id";
            listBoxPlanes.DisplayMember = "NameDestination";

        }
        public void ShowRoute()
        {
            depBox.DataSource = myService.GetAllDepartures();
            depBox.ValueMember = "Id";
            depBox.DisplayMember = "EndDestination," + "DepartureTime";
        }


        public void DeletePlane()
        {
            Plane p = null;

            try
            {
                p = (Plane)Plane_PlaneBox.SelectedItem;

                if (p != null)
                {
                    myService.DeletePlane(p.Id);
                }
            }
            catch (Exception)
            {

            }

            ShowPlanes();
        }

        public void DeleteSeatSchema()
        {
            SeatSchema s = null;
            Plane p = null;
            try
            {
                s = (SeatSchema)Plane_SeatSchema.SelectedItem;
                p = (Plane)Plane_PlaneBox.SelectedItem;
            }
            catch (Exception) { }

            if (s != null && p != null)
            {
                p.SeatSchema.Remove(s);

                myService.UpdatePlane(p);
            }

            ShowPlanes();
        }
        public void DeleteDestination()
        {
            var d = (Destination)listBoxPlanes.SelectedItem;

            myService.DeleteDestination(d.Id);
        }
        public void CreateDestination()
        {
            var p = (Plane)comboBoxDestination_ListOfPlanes.SelectedItem;
            Destination d = new Destination
            {
                NameDestination = CreateRoute_StartDestination.Text.ToString(),
                //Plane = myService.GetPlane(p.Id)
            };

            myService.CreateDestination(d);
            CreateRoute_StartDestination.Clear();
        }

        private void RefreshDestinations_Click(object sender, EventArgs e)
        {
            //listBoxPlanes.Items.Clear();
            ShowDestinations();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            CreateDestination();
        }

        private void DeleteRoute_Button_Click(object sender, EventArgs e)
        {
            DeleteDestination();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateRoute();
            depBox.Items.Clear();
            ShowRoute();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            destBox.Items.Clear();
        }
        private void depBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRoute();
        }

        private void comboBox__Bookings_Passengers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pa = (Passenger)comboBox__Bookings_Passengers.SelectedItem;

            textBox_Bookings_Passenger_FirstName.Text = pa.FirstName.ToString();
            textBox__Bookings_Passenger_LastName.Text = pa.LastName.ToString();
            textBox__Bookings_Passenger_CPR.Text = pa.CPR.ToString();
            textBox__Bookings_Passenger_PassportNo.Text = pa.PassportId.ToString();
        }

        private void Plane_RefreshPlaneButton_Click(object sender, EventArgs e)
        {
            ShowPlanes();
        }

        private void Plane_CreatePlane_Click(object sender, EventArgs e)
        {
            if (Plane_PlaneType.Text.ToString().Trim().Length > 0)
            {
                Plane p = new Plane { Type = Plane_PlaneType.Text.ToString() };
                myService.CreatePlane(p);
                ShowPlanes();
                ShowPlanesComboBox();
            }

        }

        private void Plane_PlaneBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Plane_PlaneBox.Enabled = false;
            Plane_SeatSchema.Enabled = false;

            Plane p = null;

            if (Plane_PlaneBox.Items.Count > 0)
            {

                try
                {
                    p = (Plane)Plane_PlaneBox.SelectedItem;
                }
                catch (Exception) { }

                if (p != null)
                {
                    Plane_SeatSchema.Items.Clear();

                    foreach (SeatSchema s in p.SeatSchema)
                    {
                        Plane_SeatSchema.Items.Add(s);
                    }

                    txtPlaneUpdate.Text = p.Type.ToString();
                }
            }

            Plane_SeatSchema.Enabled = true;
            Plane_PlaneBox.Enabled = true;
        }

        private void Plane_SeatSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            Plane_PlaneBox.Enabled = false;
            Plane_SeatSchema.Enabled = false;

            Plane_SeatSchemaTextBox.Text = "";

            if (Plane_SeatSchema.Items.Count > 0)
            {
                try
                {
                    Plane_SeatSchemaTextBox.Text = ((SeatSchema)Plane_SeatSchema.SelectedItem).Layout.ToString();
                }
                catch (Exception)
                { }

            }

            Plane_SeatSchema.Enabled = true;
            Plane_PlaneBox.Enabled = true;
        }

        private void Plane_DeletePlane_Click(object sender, EventArgs e)
        {
            Plane_PlaneBox.Enabled = false;
            Plane_SeatSchema.Enabled = false;
            DeletePlane();
            Plane_SeatSchema.Enabled = true;
            Plane_PlaneBox.Enabled = true;
        }

        private void Plane_DeleteSeatSchema_Click(object sender, EventArgs e)
        {
            Plane_SeatSchema.Enabled = false;
            DeleteSeatSchema();
            Plane_SeatSchema.Enabled = true;
        }

        private void Plane_CreateSeatSchema_Click(object sender, EventArgs e)
        {
            if (Plane_SeatSchemaTextBox.Text == "")
            {

            }

            //Plane_SeatSchemaTextBox.text
            //Plane_RowNumber.text
        }

        private void Plane_RefreshSeatSchema_Click(object sender, EventArgs e)
        {
            ShowPlanes();
        }

        private void bntPlane_Update_Click(object sender, EventArgs e)
        {
            Plane p = null;

            if (txtPlaneUpdate.Text != "" && Plane_PlaneBox.Items.Count > 0)
            {
                try
                {
                    p = ((Plane)Plane_PlaneBox.SelectedItem);

                    if (p != null)
                    {
                        p.Type = txtPlaneUpdate.Text.ToString();
                        myService.UpdatePlane(p);
                    }

                }
                catch (Exception)
                { }

            }
            else
            {
                txtPlaneUpdate.Text = "";
            }
        }

        private void Plane_SeatSchemaTextBox_TextChanged(object sender, EventArgs e)
        {
            string old = Plane_SeatSchemaTextBox.Text;
            TextBox textBox = sender as TextBox;

            Regex regex = new Regex(@"[^A-Ia-i|\b]");
            MatchCollection matches = regex.Matches(textBox.Text);

            if (matches.Count == 0)
            {
                Plane_SeatSchemaTextBox.Text = textBox.Text;
            }
            else
            {
                textBox.Text = old;
            }
        }

        private void Plane_RowNumber_TextChanged(object sender, EventArgs e)
        {
            string old = Plane_RowNumber.Text;
            TextBox textBox = sender as TextBox;

            Regex regex = new Regex(@"[^0-9\b]");
            MatchCollection matches = regex.Matches(textBox.Text);

            if (matches.Count == 0)
            {
                Plane_RowNumber.Text = textBox.Text;
            }
            else
            {
                textBox.Text = old;
            }
        }

        private void Plane_RowNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9\b]"))
            {
                e.Handled = true;
            }
        }

        private void Plane_SeatSchemaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^A-Ia-i|\b]"))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booking.Client.BookingServiceRemote;
using System.Net;
using System.Text.RegularExpressions;

namespace Booking.Client.UserControls
{
    public partial class PlaneControl : UserControl
    {
        ServiceClient myService = new ServiceClient();
        BookingAuthRemote.User currentUser = null;
        public PlaneControl(BookingAuthRemote.User curUser)
        {
            InitializeComponent();

            currentUser = curUser;
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            myService.ClientCredentials.UserName.UserName = currentUser.Email;
            myService.ClientCredentials.UserName.Password = currentUser.Password;

            Plane_RowNumber.ContextMenu = new ContextMenu();
            Plane_SeatSchemaTextBox.ContextMenu = new ContextMenu();
            Plane_UpdateSeatSchemaTextBox.ContextMenu = new ContextMenu();
            Plane_UpdateRowNumber.ContextMenu = new ContextMenu();

        }

        private void Plane_PlaneBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    ShowSeatSchemas();
                    txtPlaneUpdate.Text = p.Type.ToString();
                }
            }
        }

        public void ShowPlanes()
        {
            Plane_PlaneBox.DataSource = myService.GetAllPlanes();
            Plane_PlaneBox.ValueMember = "Id";
            Plane_PlaneBox.DisplayMember = "Type";
        }

        private void Plane_RefreshPlaneButton_Click(object sender, EventArgs e)
        {
            ShowPlanes();
        }

        private void Plane_DeletePlane_Click(object sender, EventArgs e)
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
            { }
            ShowPlanes();
        }

        private void Plane_CreatePlane_Click(object sender, EventArgs e)
        {
            if (Plane_PlaneType.Text.ToString().Trim().Length > 0)
            {
                Plane p = new Plane { Type = Plane_PlaneType.Text.ToString() };
                myService.CreatePlane(p);
            }
            Plane_PlaneType.Text = "";
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
            txtPlaneUpdate.Text = "";
            ShowPlanes();
        }

        private void Plane_SeatSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            Plane_UpdateSeatSchemaTextBox.Text = "";
            Plane_UpdateRowNumber.Text = "";

            if (Plane_SeatSchema.Items.Count > 0)
            {
                try
                {
                    Plane_UpdateRowNumber.Text = ((SeatSchema)Plane_SeatSchema.SelectedItem).Row.ToString();
                    Plane_UpdateSeatSchemaTextBox.Text = ((SeatSchema)Plane_SeatSchema.SelectedItem).Layout.ToString();
                }
                catch (Exception)
                { }

            }
        }

        public void ShowSeatSchemas()
        {
            try
            {
                var p = (Plane)Plane_PlaneBox.SelectedItem;
                Plane_SeatSchema.DataSource = myService.GetPlane(p.Id).SeatSchema;
                Plane_SeatSchema.ValueMember = "Id";
                Plane_SeatSchema.DisplayMember = "Row";
            }
            catch (Exception)
            { }
        }

        private void Plane_RefreshSeatSchema_Click(object sender, EventArgs e)
        {
            ShowSeatSchemas();
        }

        private void Plane_DeleteSeatSchema_Click(object sender, EventArgs e)
        {
            try
            {
                var s = (SeatSchema)Plane_SeatSchema.SelectedItem;
                var p = (Plane)Plane_PlaneBox.SelectedItem;

                if (s != null && p != null)
                {
                    p.SeatSchema.RemoveAll(x => x.Id == s.Id); //Remove(s) virker åbenbart ikke....
                }
                myService.UpdatePlane(p);
            }
            catch (Exception) { }

            ShowSeatSchemas();
        }

        private void Plane_CreateSeatSchema_Click(object sender, EventArgs e)
        {
            if (Plane_SeatSchemaTextBox.Text.ToString().Trim().Length > 0 && Plane_RowNumber.Text.ToString().Trim().Length > 0)
            {
                bool exists = false;

                try
                {
                    int rowToAdd = Convert.ToInt32(Plane_RowNumber.Text);

                    Plane p = (Plane)Plane_PlaneBox.SelectedItem;

                    foreach (SeatSchema s in p.SeatSchema)
                    {
                        if (s.Row == rowToAdd)
                        {
                            exists = true;
                        }
                    }

                    if (!exists)
                    {
                        SeatSchema ss = new SeatSchema { Layout = Plane_SeatSchemaTextBox.Text, Row = Convert.ToInt32(Plane_RowNumber.Text) };

                        p.SeatSchema.Add(ss);
                        myService.UpdatePlane(p);
                    }
                }
                catch (Exception)
                { }
            }
            Plane_RowNumber.Text = "";
            Plane_SeatSchemaTextBox.Text = "";
            ShowSeatSchemas();
        }

        private void Plane_UpdateSeatSchema_Click(object sender, EventArgs e)
        {
            if (Plane_UpdateSeatSchemaTextBox.Text.ToString().Trim().Length > 0 && Plane_UpdateRowNumber.Text.ToString().Trim().Length > 0)
            {
                bool exists = false;

                try
                {
                    int rowToAdd = Convert.ToInt32(Plane_UpdateRowNumber.Text);

                    Plane p = (Plane)Plane_PlaneBox.SelectedItem;

                    foreach (SeatSchema s in p.SeatSchema)
                    {
                        if (s.Row == rowToAdd)
                        {
                            exists = true;
                        }
                    }

                    if (!exists)
                    {
                        var ss = (SeatSchema)Plane_SeatSchema.SelectedItem;
                        if (ss != null)
                        {
                            ss.Layout = Plane_UpdateSeatSchemaTextBox.Text.ToString();
                            ss.Row = Convert.ToInt32(Plane_UpdateRowNumber.Text);
                            p.SeatSchema.Add(ss);
                            myService.UpdatePlane(p);
                        }
                    }
                }
                catch (Exception)
                { }
            }
            Plane_UpdateRowNumber.Text = "";
            Plane_UpdateSeatSchemaTextBox.Text = "";
            ShowSeatSchemas();
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

        private void Plane_UpdateSeatSchemaTextBox_TextChanged(object sender, EventArgs e)
        {
            string old = Plane_UpdateSeatSchemaTextBox.Text;
            TextBox textBox = sender as TextBox;

            Regex regex = new Regex(@"[^A-Ia-i|\b]");
            MatchCollection matches = regex.Matches(textBox.Text);

            if (matches.Count == 0)
            {
                Plane_UpdateSeatSchemaTextBox.Text = textBox.Text;
            }
            else
            {
                textBox.Text = old;
            }
        }

        private void Plane_UpdateRowNumber_TextChanged(object sender, EventArgs e)
        {
            string old = Plane_UpdateRowNumber.Text;
            TextBox textBox = sender as TextBox;

            Regex regex = new Regex(@"[^0-9\b]");
            MatchCollection matches = regex.Matches(textBox.Text);

            if (matches.Count == 0)
            {
                Plane_UpdateRowNumber.Text = textBox.Text;
            }
            else
            {
                textBox.Text = old;
            }
        }

        private void Plane_UpdateRowNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9\b]"))
            {
                e.Handled = true;
            }
        }

        private void Plane_UpdateSeatSchemaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^A-Ia-i|\b]"))
            {
                e.Handled = true;
            }
        }
    }
}

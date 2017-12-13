namespace Booking.Client
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlaneTab = new System.Windows.Forms.TabControl();
            this.tabCreateRoute = new System.Windows.Forms.TabPage();
            this.tabPageDeparture = new System.Windows.Forms.TabPage();
            this.tabPagePassengers = new System.Windows.Forms.TabPage();
            this.tabPageBookings = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.destinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlaneTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaneTab
            // 
            this.PlaneTab.Controls.Add(this.tabCreateRoute);
            this.PlaneTab.Controls.Add(this.tabPageDeparture);
            this.PlaneTab.Controls.Add(this.tabPagePassengers);
            this.PlaneTab.Controls.Add(this.tabPageBookings);
            this.PlaneTab.Controls.Add(this.tabPage1);
            this.PlaneTab.Location = new System.Drawing.Point(-2, -1);
            this.PlaneTab.Name = "PlaneTab";
            this.PlaneTab.SelectedIndex = 0;
            this.PlaneTab.Size = new System.Drawing.Size(1086, 707);
            this.PlaneTab.TabIndex = 0;
            this.PlaneTab.Tag = "Route";
            this.PlaneTab.SelectedIndexChanged += new System.EventHandler(this.PlaneTab_SelectedIndexChanged);
            // 
            // tabCreateRoute
            // 
            this.tabCreateRoute.Location = new System.Drawing.Point(4, 29);
            this.tabCreateRoute.Name = "tabCreateRoute";
            this.tabCreateRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateRoute.Size = new System.Drawing.Size(1078, 674);
            this.tabCreateRoute.TabIndex = 0;
            this.tabCreateRoute.Text = "Plane Destination";
            this.tabCreateRoute.UseVisualStyleBackColor = true;
            // 
            // tabPageDeparture
            // 
            this.tabPageDeparture.Location = new System.Drawing.Point(4, 29);
            this.tabPageDeparture.Name = "tabPageDeparture";
            this.tabPageDeparture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeparture.Size = new System.Drawing.Size(1078, 674);
            this.tabPageDeparture.TabIndex = 1;
            this.tabPageDeparture.Text = "Departure";
            this.tabPageDeparture.UseVisualStyleBackColor = true;
            // 
            // tabPagePassengers
            // 
            this.tabPagePassengers.Location = new System.Drawing.Point(4, 29);
            this.tabPagePassengers.Name = "tabPagePassengers";
            this.tabPagePassengers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePassengers.Size = new System.Drawing.Size(1078, 674);
            this.tabPagePassengers.TabIndex = 2;
            this.tabPagePassengers.Text = "Passengers";
            this.tabPagePassengers.UseVisualStyleBackColor = true;
            // 
            // tabPageBookings
            // 
            this.tabPageBookings.Location = new System.Drawing.Point(4, 29);
            this.tabPageBookings.Name = "tabPageBookings";
            this.tabPageBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookings.Size = new System.Drawing.Size(1078, 674);
            this.tabPageBookings.TabIndex = 3;
            this.tabPageBookings.Text = "Bookings";
            this.tabPageBookings.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 674);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Plane";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // destinationBindingSource
            // 
            this.destinationBindingSource.DataSource = typeof(Booking.Client.BookingServiceRemote.Destination);
            // 
            // MainFrame
            // 
            this.ClientSize = new System.Drawing.Size(1080, 704);
            this.Controls.Add(this.PlaneTab);
            this.Name = "MainFrame";
            this.PlaneTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl PlaneTab;
        private System.Windows.Forms.TabPage tabCreateRoute;
        private System.Windows.Forms.TabPage tabPageDeparture;
        private System.Windows.Forms.TabPage tabPagePassengers;
        private System.Windows.Forms.TabPage tabPageBookings;
        private System.Windows.Forms.BindingSource destinationBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
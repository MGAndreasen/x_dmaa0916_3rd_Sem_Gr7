namespace Booking.Client.UserControls
{
    partial class DepartureControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Departure_DeleteDepartureBtn = new System.Windows.Forms.Button();
            this.Departure_RefreshDepartureBtn = new System.Windows.Forms.Button();
            this.Departure_ListDespartures = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calenderRoute = new System.Windows.Forms.MonthCalendar();
            this.Departure_RefreshDestinationsBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Departure_ListDestinations = new System.Windows.Forms.ListBox();
            this.comboBoxDepartures_ListOfPlanes = new System.Windows.Forms.ComboBox();
            this.Departure_CreateDepartureBtn = new System.Windows.Forms.Button();
            this.LoadPlanes = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Departure_DeleteDepartureBtn);
            this.groupBox7.Controls.Add(this.Departure_RefreshDepartureBtn);
            this.groupBox7.Controls.Add(this.Departure_ListDespartures);
            this.groupBox7.Location = new System.Drawing.Point(686, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(457, 617);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Departures";
            // 
            // Departure_DeleteDepartureBtn
            // 
            this.Departure_DeleteDepartureBtn.Location = new System.Drawing.Point(21, 143);
            this.Departure_DeleteDepartureBtn.Name = "Departure_DeleteDepartureBtn";
            this.Departure_DeleteDepartureBtn.Size = new System.Drawing.Size(133, 67);
            this.Departure_DeleteDepartureBtn.TabIndex = 17;
            this.Departure_DeleteDepartureBtn.Text = "Delete departure";
            this.Departure_DeleteDepartureBtn.UseVisualStyleBackColor = true;
            this.Departure_DeleteDepartureBtn.Click += new System.EventHandler(this.Departure_DeleteDepartureBtn_Click);
            // 
            // Departure_RefreshDepartureBtn
            // 
            this.Departure_RefreshDepartureBtn.Location = new System.Drawing.Point(21, 54);
            this.Departure_RefreshDepartureBtn.Name = "Departure_RefreshDepartureBtn";
            this.Departure_RefreshDepartureBtn.Size = new System.Drawing.Size(133, 64);
            this.Departure_RefreshDepartureBtn.TabIndex = 16;
            this.Departure_RefreshDepartureBtn.Text = "Refresh departures";
            this.Departure_RefreshDepartureBtn.UseVisualStyleBackColor = true;
            this.Departure_RefreshDepartureBtn.Click += new System.EventHandler(this.Departure_RefreshDepartureBtn_Click);
            // 
            // Departure_ListDespartures
            // 
            this.Departure_ListDespartures.FormattingEnabled = true;
            this.Departure_ListDespartures.ItemHeight = 20;
            this.Departure_ListDespartures.Location = new System.Drawing.Point(176, 54);
            this.Departure_ListDespartures.Name = "Departure_ListDespartures";
            this.Departure_ListDespartures.Size = new System.Drawing.Size(265, 544);
            this.Departure_ListDespartures.TabIndex = 14;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.LoadPlanes);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.calenderRoute);
            this.groupBox8.Controls.Add(this.Departure_RefreshDestinationsBtn);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.Departure_ListDestinations);
            this.groupBox8.Controls.Add(this.comboBoxDepartures_ListOfPlanes);
            this.groupBox8.Controls.Add(this.Departure_CreateDepartureBtn);
            this.groupBox8.Location = new System.Drawing.Point(18, 26);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(579, 617);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Create Departure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Select a date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select destination";
            // 
            // calenderRoute
            // 
            this.calenderRoute.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2017, 12, 24, 0, 0, 0, 0)};
            this.calenderRoute.Location = new System.Drawing.Point(260, 54);
            this.calenderRoute.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.calenderRoute.MaxSelectionCount = 1;
            this.calenderRoute.MinDate = new System.DateTime(2017, 12, 5, 0, 0, 0, 0);
            this.calenderRoute.Name = "calenderRoute";
            this.calenderRoute.ShowWeekNumbers = true;
            this.calenderRoute.TabIndex = 10;
            // 
            // Departure_RefreshDestinationsBtn
            // 
            this.Departure_RefreshDestinationsBtn.Location = new System.Drawing.Point(241, 532);
            this.Departure_RefreshDestinationsBtn.Name = "Departure_RefreshDestinationsBtn";
            this.Departure_RefreshDestinationsBtn.Size = new System.Drawing.Size(118, 66);
            this.Departure_RefreshDestinationsBtn.TabIndex = 13;
            this.Departure_RefreshDestinationsBtn.Text = "Refresh destinations";
            this.Departure_RefreshDestinationsBtn.UseVisualStyleBackColor = true;
            this.Departure_RefreshDestinationsBtn.Click += new System.EventHandler(this.Departure_RefreshDestinationsBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select a plane";
            // 
            // Departure_ListDestinations
            // 
            this.Departure_ListDestinations.FormattingEnabled = true;
            this.Departure_ListDestinations.ItemHeight = 20;
            this.Departure_ListDestinations.Location = new System.Drawing.Point(15, 54);
            this.Departure_ListDestinations.Name = "Departure_ListDestinations";
            this.Departure_ListDestinations.Size = new System.Drawing.Size(220, 544);
            this.Departure_ListDestinations.TabIndex = 11;
            // 
            // comboBoxDepartures_ListOfPlanes
            // 
            this.comboBoxDepartures_ListOfPlanes.FormattingEnabled = true;
            this.comboBoxDepartures_ListOfPlanes.Location = new System.Drawing.Point(260, 376);
            this.comboBoxDepartures_ListOfPlanes.Name = "comboBoxDepartures_ListOfPlanes";
            this.comboBoxDepartures_ListOfPlanes.Size = new System.Drawing.Size(257, 28);
            this.comboBoxDepartures_ListOfPlanes.TabIndex = 0;
            // 
            // Departure_CreateDepartureBtn
            // 
            this.Departure_CreateDepartureBtn.BackColor = System.Drawing.Color.Transparent;
            this.Departure_CreateDepartureBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Departure_CreateDepartureBtn.Location = new System.Drawing.Point(414, 532);
            this.Departure_CreateDepartureBtn.Name = "Departure_CreateDepartureBtn";
            this.Departure_CreateDepartureBtn.Size = new System.Drawing.Size(103, 66);
            this.Departure_CreateDepartureBtn.TabIndex = 12;
            this.Departure_CreateDepartureBtn.Text = "Create departure";
            this.Departure_CreateDepartureBtn.UseVisualStyleBackColor = false;
            this.Departure_CreateDepartureBtn.Click += new System.EventHandler(this.Departure_CreateDepartureBtn_Click);
            // 
            // LoadPlanes
            // 
            this.LoadPlanes.Location = new System.Drawing.Point(260, 422);
            this.LoadPlanes.Name = "LoadPlanes";
            this.LoadPlanes.Size = new System.Drawing.Size(177, 41);
            this.LoadPlanes.TabIndex = 16;
            this.LoadPlanes.Text = "Load Planes";
            this.LoadPlanes.UseVisualStyleBackColor = true;
            this.LoadPlanes.Click += new System.EventHandler(this.LoadPlanes_Click);
            // 
            // DepartureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Name = "DepartureControl";
            this.Size = new System.Drawing.Size(1160, 729);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Departure_DeleteDepartureBtn;
        private System.Windows.Forms.Button Departure_RefreshDepartureBtn;
        private System.Windows.Forms.ListBox Departure_ListDespartures;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar calenderRoute;
        private System.Windows.Forms.Button Departure_RefreshDestinationsBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Departure_ListDestinations;
        private System.Windows.Forms.ComboBox comboBoxDepartures_ListOfPlanes;
        private System.Windows.Forms.Button Departure_CreateDepartureBtn;
        private System.Windows.Forms.Button LoadPlanes;
    }
}

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCreateRoute = new System.Windows.Forms.TabPage();
            this.textBoxDateTime = new System.Windows.Forms.TextBox();
            this.RefreshDestinations = new System.Windows.Forms.Button();
            this.CreateRoute_monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.listBoxPlanes = new System.Windows.Forms.ListBox();
            this.comboBoxDestination_ListOfPlanes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateRoute_EndDestination = new System.Windows.Forms.TextBox();
            this.CreateRoute_StartDestination = new System.Windows.Forms.TextBox();
            this.tabPageSeats = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSeats_ListOfPlanes = new System.Windows.Forms.ComboBox();
            this.tabPagePassengers = new System.Windows.Forms.TabPage();
            this.listBoxPassengers = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPassengers_Planes = new System.Windows.Forms.ComboBox();
            this.tabPageBookings = new System.Windows.Forms.TabPage();
            this.listBoxListOfBookings = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Bookings_StartDestination = new System.Windows.Forms.TextBox();
            this.textBox_Bookings_EndDestination = new System.Windows.Forms.TextBox();
            this.textBox_Bookings_Plane = new System.Windows.Forms.TextBox();
            this.textBox_Bookings_Date = new System.Windows.Forms.TextBox();
            this.textBox__Bookings_Customer = new System.Windows.Forms.TextBox();
            this.comboBox__Bookings_Passengers = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_Bookings_Passenger = new System.Windows.Forms.Label();
            this.textBox_Bookings_Passenger_FirstName = new System.Windows.Forms.TextBox();
            this.textBox__Bookings_Passenger_LastName = new System.Windows.Forms.TextBox();
            this.textBox__Bookings_Passenger_CPR = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox__Bookings_Passenger_PassportNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCreateRoute.SuspendLayout();
            this.tabPageSeats.SuspendLayout();
            this.tabPagePassengers.SuspendLayout();
            this.tabPageBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCreateRoute);
            this.tabControl1.Controls.Add(this.tabPageSeats);
            this.tabControl1.Controls.Add(this.tabPagePassengers);
            this.tabControl1.Controls.Add(this.tabPageBookings);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 707);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCreateRoute
            // 
            this.tabCreateRoute.Controls.Add(this.textBoxDateTime);
            this.tabCreateRoute.Controls.Add(this.RefreshDestinations);
            this.tabCreateRoute.Controls.Add(this.CreateRoute_monthCalendar);
            this.tabCreateRoute.Controls.Add(this.listBoxPlanes);
            this.tabCreateRoute.Controls.Add(this.comboBoxDestination_ListOfPlanes);
            this.tabCreateRoute.Controls.Add(this.label4);
            this.tabCreateRoute.Controls.Add(this.Button);
            this.tabCreateRoute.Controls.Add(this.label3);
            this.tabCreateRoute.Controls.Add(this.label2);
            this.tabCreateRoute.Controls.Add(this.label1);
            this.tabCreateRoute.Controls.Add(this.CreateRoute_EndDestination);
            this.tabCreateRoute.Controls.Add(this.CreateRoute_StartDestination);
            this.tabCreateRoute.Location = new System.Drawing.Point(4, 29);
            this.tabCreateRoute.Name = "tabCreateRoute";
            this.tabCreateRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateRoute.Size = new System.Drawing.Size(1078, 674);
            this.tabCreateRoute.TabIndex = 0;
            this.tabCreateRoute.Text = "Plane Destination";
            this.tabCreateRoute.UseVisualStyleBackColor = true;
            this.tabCreateRoute.Click += new System.EventHandler(this.tabCreateRoute_Click);
            // 
            // textBoxDateTime
            // 
            this.textBoxDateTime.Location = new System.Drawing.Point(319, 321);
            this.textBoxDateTime.Name = "textBoxDateTime";
            this.textBoxDateTime.ReadOnly = true;
            this.textBoxDateTime.Size = new System.Drawing.Size(143, 26);
            this.textBoxDateTime.TabIndex = 13;
            // 
            // RefreshDestinations
            // 
            this.RefreshDestinations.Location = new System.Drawing.Point(462, 584);
            this.RefreshDestinations.Name = "RefreshDestinations";
            this.RefreshDestinations.Size = new System.Drawing.Size(101, 56);
            this.RefreshDestinations.TabIndex = 12;
            this.RefreshDestinations.Text = "Refresh";
            this.RefreshDestinations.UseVisualStyleBackColor = true;
            this.RefreshDestinations.Click += new System.EventHandler(this.RefreshDestinations_Click);
            // 
            // CreateRoute_monthCalendar
            // 
            this.CreateRoute_monthCalendar.Location = new System.Drawing.Point(283, 57);
            this.CreateRoute_monthCalendar.Name = "CreateRoute_monthCalendar";
            this.CreateRoute_monthCalendar.TabIndex = 11;
            this.CreateRoute_monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CreateRoute_monthCalendar_DateChanged);
            // 
            // listBoxPlanes
            // 
            this.listBoxPlanes.FormattingEnabled = true;
            this.listBoxPlanes.ItemHeight = 20;
            this.listBoxPlanes.Location = new System.Drawing.Point(598, 57);
            this.listBoxPlanes.Name = "listBoxPlanes";
            this.listBoxPlanes.Size = new System.Drawing.Size(468, 584);
            this.listBoxPlanes.TabIndex = 10;
            // 
            // comboBoxDestination_ListOfPlanes
            // 
            this.comboBoxDestination_ListOfPlanes.FormattingEnabled = true;
            this.comboBoxDestination_ListOfPlanes.Location = new System.Drawing.Point(67, 261);
            this.comboBoxDestination_ListOfPlanes.Name = "comboBoxDestination_ListOfPlanes";
            this.comboBoxDestination_ListOfPlanes.Size = new System.Drawing.Size(124, 28);
            this.comboBoxDestination_ListOfPlanes.TabIndex = 9;
            this.comboBoxDestination_ListOfPlanes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDestination_ListOfPlanes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "List Of All Plane Routes: ";
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(67, 584);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(124, 56);
            this.Button.TabIndex = 7;
            this.Button.Text = "Create";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.DestinationCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select A Plane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Destination ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateRoute_EndDestination
            // 
            this.CreateRoute_EndDestination.Location = new System.Drawing.Point(67, 155);
            this.CreateRoute_EndDestination.Name = "CreateRoute_EndDestination";
            this.CreateRoute_EndDestination.Size = new System.Drawing.Size(124, 26);
            this.CreateRoute_EndDestination.TabIndex = 1;
            // 
            // CreateRoute_StartDestination
            // 
            this.CreateRoute_StartDestination.Location = new System.Drawing.Point(67, 57);
            this.CreateRoute_StartDestination.Name = "CreateRoute_StartDestination";
            this.CreateRoute_StartDestination.Size = new System.Drawing.Size(124, 26);
            this.CreateRoute_StartDestination.TabIndex = 0;
            // 
            // tabPageSeats
            // 
            this.tabPageSeats.Controls.Add(this.label7);
            this.tabPageSeats.Controls.Add(this.textBox4);
            this.tabPageSeats.Controls.Add(this.radioButton2);
            this.tabPageSeats.Controls.Add(this.radioButton1);
            this.tabPageSeats.Controls.Add(this.label6);
            this.tabPageSeats.Controls.Add(this.button1);
            this.tabPageSeats.Controls.Add(this.label5);
            this.tabPageSeats.Controls.Add(this.comboBoxSeats_ListOfPlanes);
            this.tabPageSeats.Location = new System.Drawing.Point(4, 29);
            this.tabPageSeats.Name = "tabPageSeats";
            this.tabPageSeats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeats.Size = new System.Drawing.Size(1078, 674);
            this.tabPageSeats.TabIndex = 1;
            this.tabPageSeats.Text = "Seats";
            this.tabPageSeats.UseVisualStyleBackColor = true;
            this.tabPageSeats.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "id";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 7;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 281);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Booked";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 242);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Available";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Availability";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create seat ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select a plane";
            // 
            // comboBoxSeats_ListOfPlanes
            // 
            this.comboBoxSeats_ListOfPlanes.FormattingEnabled = true;
            this.comboBoxSeats_ListOfPlanes.Location = new System.Drawing.Point(25, 62);
            this.comboBoxSeats_ListOfPlanes.Name = "comboBoxSeats_ListOfPlanes";
            this.comboBoxSeats_ListOfPlanes.Size = new System.Drawing.Size(248, 28);
            this.comboBoxSeats_ListOfPlanes.TabIndex = 0;
            // 
            // tabPagePassengers
            // 
            this.tabPagePassengers.Controls.Add(this.listBoxPassengers);
            this.tabPagePassengers.Controls.Add(this.label8);
            this.tabPagePassengers.Controls.Add(this.comboBoxPassengers_Planes);
            this.tabPagePassengers.Location = new System.Drawing.Point(4, 29);
            this.tabPagePassengers.Name = "tabPagePassengers";
            this.tabPagePassengers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePassengers.Size = new System.Drawing.Size(1078, 674);
            this.tabPagePassengers.TabIndex = 2;
            this.tabPagePassengers.Text = "Passengers";
            this.tabPagePassengers.UseVisualStyleBackColor = true;
            // 
            // listBoxPassengers
            // 
            this.listBoxPassengers.FormattingEnabled = true;
            this.listBoxPassengers.ItemHeight = 20;
            this.listBoxPassengers.Location = new System.Drawing.Point(31, 116);
            this.listBoxPassengers.Name = "listBoxPassengers";
            this.listBoxPassengers.Size = new System.Drawing.Size(324, 524);
            this.listBoxPassengers.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Select a plane";
            // 
            // comboBoxPassengers_Planes
            // 
            this.comboBoxPassengers_Planes.FormattingEnabled = true;
            this.comboBoxPassengers_Planes.Location = new System.Drawing.Point(31, 59);
            this.comboBoxPassengers_Planes.Name = "comboBoxPassengers_Planes";
            this.comboBoxPassengers_Planes.Size = new System.Drawing.Size(186, 28);
            this.comboBoxPassengers_Planes.TabIndex = 0;
            this.comboBoxPassengers_Planes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPassengers_SelectedIndexChanged);
            // 
            // tabPageBookings
            // 
            this.tabPageBookings.Controls.Add(this.label20);
            this.tabPageBookings.Controls.Add(this.textBox__Bookings_Passenger_PassportNo);
            this.tabPageBookings.Controls.Add(this.label19);
            this.tabPageBookings.Controls.Add(this.label18);
            this.tabPageBookings.Controls.Add(this.label17);
            this.tabPageBookings.Controls.Add(this.textBox__Bookings_Passenger_CPR);
            this.tabPageBookings.Controls.Add(this.textBox__Bookings_Passenger_LastName);
            this.tabPageBookings.Controls.Add(this.textBox_Bookings_Passenger_FirstName);
            this.tabPageBookings.Controls.Add(this.label_Bookings_Passenger);
            this.tabPageBookings.Controls.Add(this.label16);
            this.tabPageBookings.Controls.Add(this.label15);
            this.tabPageBookings.Controls.Add(this.label14);
            this.tabPageBookings.Controls.Add(this.label13);
            this.tabPageBookings.Controls.Add(this.label12);
            this.tabPageBookings.Controls.Add(this.label11);
            this.tabPageBookings.Controls.Add(this.label10);
            this.tabPageBookings.Controls.Add(this.comboBox__Bookings_Passengers);
            this.tabPageBookings.Controls.Add(this.textBox__Bookings_Customer);
            this.tabPageBookings.Controls.Add(this.textBox_Bookings_Date);
            this.tabPageBookings.Controls.Add(this.textBox_Bookings_Plane);
            this.tabPageBookings.Controls.Add(this.textBox_Bookings_EndDestination);
            this.tabPageBookings.Controls.Add(this.textBox_Bookings_StartDestination);
            this.tabPageBookings.Controls.Add(this.label9);
            this.tabPageBookings.Controls.Add(this.listBoxListOfBookings);
            this.tabPageBookings.Location = new System.Drawing.Point(4, 29);
            this.tabPageBookings.Name = "tabPageBookings";
            this.tabPageBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookings.Size = new System.Drawing.Size(1078, 674);
            this.tabPageBookings.TabIndex = 3;
            this.tabPageBookings.Text = "Bookings";
            this.tabPageBookings.UseVisualStyleBackColor = true;
            // 
            // listBoxListOfBookings
            // 
            this.listBoxListOfBookings.FormattingEnabled = true;
            this.listBoxListOfBookings.ItemHeight = 20;
            this.listBoxListOfBookings.Location = new System.Drawing.Point(10, 79);
            this.listBoxListOfBookings.Name = "listBoxListOfBookings";
            this.listBoxListOfBookings.Size = new System.Drawing.Size(345, 584);
            this.listBoxListOfBookings.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "List of bookings";
            // 
            // textBox_Bookings_StartDestination
            // 
            this.textBox_Bookings_StartDestination.Location = new System.Drawing.Point(721, 79);
            this.textBox_Bookings_StartDestination.Name = "textBox_Bookings_StartDestination";
            this.textBox_Bookings_StartDestination.Size = new System.Drawing.Size(179, 26);
            this.textBox_Bookings_StartDestination.TabIndex = 2;
            // 
            // textBox_Bookings_EndDestination
            // 
            this.textBox_Bookings_EndDestination.Location = new System.Drawing.Point(721, 120);
            this.textBox_Bookings_EndDestination.Name = "textBox_Bookings_EndDestination";
            this.textBox_Bookings_EndDestination.Size = new System.Drawing.Size(179, 26);
            this.textBox_Bookings_EndDestination.TabIndex = 3;
            // 
            // textBox_Bookings_Plane
            // 
            this.textBox_Bookings_Plane.Location = new System.Drawing.Point(721, 162);
            this.textBox_Bookings_Plane.Name = "textBox_Bookings_Plane";
            this.textBox_Bookings_Plane.Size = new System.Drawing.Size(179, 26);
            this.textBox_Bookings_Plane.TabIndex = 4;
            // 
            // textBox_Bookings_Date
            // 
            this.textBox_Bookings_Date.Location = new System.Drawing.Point(721, 205);
            this.textBox_Bookings_Date.Name = "textBox_Bookings_Date";
            this.textBox_Bookings_Date.Size = new System.Drawing.Size(179, 26);
            this.textBox_Bookings_Date.TabIndex = 5;
            // 
            // textBox__Bookings_Customer
            // 
            this.textBox__Bookings_Customer.Location = new System.Drawing.Point(721, 247);
            this.textBox__Bookings_Customer.Name = "textBox__Bookings_Customer";
            this.textBox__Bookings_Customer.Size = new System.Drawing.Size(179, 26);
            this.textBox__Bookings_Customer.TabIndex = 6;
            // 
            // comboBox__Bookings_Passengers
            // 
            this.comboBox__Bookings_Passengers.FormattingEnabled = true;
            this.comboBox__Bookings_Passengers.Location = new System.Drawing.Point(721, 288);
            this.comboBox__Bookings_Passengers.Name = "comboBox__Bookings_Passengers";
            this.comboBox__Bookings_Passengers.Size = new System.Drawing.Size(179, 28);
            this.comboBox__Bookings_Passengers.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Start destination";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(589, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "End destination";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(589, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Plane";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(589, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(589, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Customer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(589, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Passengers";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(589, 377);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Passenger: ";
            // 
            // label_Bookings_Passenger
            // 
            this.label_Bookings_Passenger.AutoSize = true;
            this.label_Bookings_Passenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bookings_Passenger.Location = new System.Drawing.Point(717, 377);
            this.label_Bookings_Passenger.Name = "label_Bookings_Passenger";
            this.label_Bookings_Passenger.Size = new System.Drawing.Size(159, 20);
            this.label_Bookings_Passenger.TabIndex = 15;
            this.label_Bookings_Passenger.Text = "Chosen passenger";
            // 
            // textBox_Bookings_Passenger_FirstName
            // 
            this.textBox_Bookings_Passenger_FirstName.Location = new System.Drawing.Point(721, 427);
            this.textBox_Bookings_Passenger_FirstName.Name = "textBox_Bookings_Passenger_FirstName";
            this.textBox_Bookings_Passenger_FirstName.Size = new System.Drawing.Size(179, 26);
            this.textBox_Bookings_Passenger_FirstName.TabIndex = 16;
            // 
            // textBox__Bookings_Passenger_LastName
            // 
            this.textBox__Bookings_Passenger_LastName.Location = new System.Drawing.Point(721, 468);
            this.textBox__Bookings_Passenger_LastName.Name = "textBox__Bookings_Passenger_LastName";
            this.textBox__Bookings_Passenger_LastName.Size = new System.Drawing.Size(179, 26);
            this.textBox__Bookings_Passenger_LastName.TabIndex = 17;
            // 
            // textBox__Bookings_Passenger_CPR
            // 
            this.textBox__Bookings_Passenger_CPR.Location = new System.Drawing.Point(721, 510);
            this.textBox__Bookings_Passenger_CPR.Name = "textBox__Bookings_Passenger_CPR";
            this.textBox__Bookings_Passenger_CPR.Size = new System.Drawing.Size(179, 26);
            this.textBox__Bookings_Passenger_CPR.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(589, 430);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "First name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(589, 471);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Last name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(589, 513);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "CPR";
            // 
            // textBox__Bookings_Passenger_PassportNo
            // 
            this.textBox__Bookings_Passenger_PassportNo.Location = new System.Drawing.Point(721, 553);
            this.textBox__Bookings_Passenger_PassportNo.Name = "textBox__Bookings_Passenger_PassportNo";
            this.textBox__Bookings_Passenger_PassportNo.Size = new System.Drawing.Size(179, 26);
            this.textBox__Bookings_Passenger_PassportNo.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(589, 556);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "Passport number";
            // 
            // MainFrame
            // 
            this.ClientSize = new System.Drawing.Size(1080, 704);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabCreateRoute.ResumeLayout(false);
            this.tabCreateRoute.PerformLayout();
            this.tabPageSeats.ResumeLayout(false);
            this.tabPageSeats.PerformLayout();
            this.tabPagePassengers.ResumeLayout(false);
            this.tabPagePassengers.PerformLayout();
            this.tabPageBookings.ResumeLayout(false);
            this.tabPageBookings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCreateRoute;
        private System.Windows.Forms.TabPage tabPageSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateRoute_EndDestination;
        private System.Windows.Forms.TextBox CreateRoute_StartDestination;
        private System.Windows.Forms.ComboBox comboBoxDestination_ListOfPlanes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSeats_ListOfPlanes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listBoxPlanes;
        private System.Windows.Forms.TabPage tabPagePassengers;
        private System.Windows.Forms.ListBox listBoxPassengers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPassengers_Planes;
        private System.Windows.Forms.MonthCalendar CreateRoute_monthCalendar;
        private System.Windows.Forms.Button RefreshDestinations;
        private System.Windows.Forms.TextBox textBoxDateTime;
        private System.Windows.Forms.TabPage tabPageBookings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxListOfBookings;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox__Bookings_Passengers;
        private System.Windows.Forms.TextBox textBox__Bookings_Customer;
        private System.Windows.Forms.TextBox textBox_Bookings_Date;
        private System.Windows.Forms.TextBox textBox_Bookings_Plane;
        private System.Windows.Forms.TextBox textBox_Bookings_EndDestination;
        private System.Windows.Forms.TextBox textBox_Bookings_StartDestination;
        private System.Windows.Forms.Label label_Bookings_Passenger;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox__Bookings_Passenger_PassportNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox__Bookings_Passenger_CPR;
        private System.Windows.Forms.TextBox textBox__Bookings_Passenger_LastName;
        private System.Windows.Forms.TextBox textBox_Bookings_Passenger_FirstName;
    }
}
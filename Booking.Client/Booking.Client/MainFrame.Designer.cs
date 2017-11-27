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
            this.RefreshDestinations = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCreateRoute.SuspendLayout();
            this.tabPageSeats.SuspendLayout();
            this.tabPagePassengers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCreateRoute);
            this.tabControl1.Controls.Add(this.tabPageSeats);
            this.tabControl1.Controls.Add(this.tabPagePassengers);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 707);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCreateRoute
            // 
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
            // 
            // CreateRoute_monthCalendar
            // 
            this.CreateRoute_monthCalendar.Location = new System.Drawing.Point(283, 57);
            this.CreateRoute_monthCalendar.Name = "CreateRoute_monthCalendar";
            this.CreateRoute_monthCalendar.TabIndex = 11;
            // 
            // listBoxPlanes
            // 
            this.listBoxPlanes.FormattingEnabled = true;
            this.listBoxPlanes.ItemHeight = 20;
            this.listBoxPlanes.Location = new System.Drawing.Point(598, 57);
            this.listBoxPlanes.Name = "listBoxPlanes";
            this.listBoxPlanes.Size = new System.Drawing.Size(468, 604);
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
            this.listBoxPassengers.Size = new System.Drawing.Size(324, 544);
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
    }
}
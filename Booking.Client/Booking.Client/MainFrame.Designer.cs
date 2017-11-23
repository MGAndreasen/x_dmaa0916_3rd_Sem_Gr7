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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabSeat = new System.Windows.Forms.TabPage();
            this.comboBoxSeats_ListOfPlanes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabSeat);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 707);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1070, 660);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plane Destination";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabSeat
            // 
            this.tabSeat.Controls.Add(this.label1);
            this.tabSeat.Controls.Add(this.comboBoxSeats_ListOfPlanes);
            this.tabSeat.Location = new System.Drawing.Point(8, 39);
            this.tabSeat.Name = "tabSeat";
            this.tabSeat.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeat.Size = new System.Drawing.Size(1070, 660);
            this.tabSeat.TabIndex = 1;
            this.tabSeat.Text = "Seats";
            this.tabSeat.UseVisualStyleBackColor = true;
            this.tabSeat.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBoxSeats_ListOfPlanes
            // 
            this.comboBoxSeats_ListOfPlanes.FormattingEnabled = true;
            this.comboBoxSeats_ListOfPlanes.Location = new System.Drawing.Point(22, 63);
            this.comboBoxSeats_ListOfPlanes.Name = "comboBoxSeats_ListOfPlanes";
            this.comboBoxSeats_ListOfPlanes.Size = new System.Drawing.Size(282, 33);
            this.comboBoxSeats_ListOfPlanes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a plane";
            // 
            // MainFrame
            // 
            this.ClientSize = new System.Drawing.Size(1080, 704);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabSeat.ResumeLayout(false);
            this.tabSeat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSeats_ListOfPlanes;
    }
}
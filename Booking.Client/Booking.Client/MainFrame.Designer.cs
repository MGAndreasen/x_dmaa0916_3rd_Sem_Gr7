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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPageSeats = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSeats_ListOfPlanes = new System.Windows.Forms.ComboBox();
            this.listBoxPlanes = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageSeats);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 707);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxPlanes);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Button);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plane Destination";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 9;
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
            this.Button.Text = "GO";
            this.Button.UseVisualStyleBackColor = true;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 26);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 26);
            this.textBox2.TabIndex = 0;
            // 
            // tabPageSeats
            // 
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select a plane";
            // 
            // comboBoxSeats_ListOfPlanes
            // 
            this.comboBoxSeats_ListOfPlanes.FormattingEnabled = true;
            this.comboBoxSeats_ListOfPlanes.Location = new System.Drawing.Point(34, 594);
            this.comboBoxSeats_ListOfPlanes.Name = "comboBoxSeats_ListOfPlanes";
            this.comboBoxSeats_ListOfPlanes.Size = new System.Drawing.Size(248, 28);
            this.comboBoxSeats_ListOfPlanes.TabIndex = 0;
            // 
            // listBoxPlanes
            // 
            this.listBoxPlanes.FormattingEnabled = true;
            this.listBoxPlanes.ItemHeight = 20;
            this.listBoxPlanes.Location = new System.Drawing.Point(643, 37);
            this.listBoxPlanes.Name = "listBoxPlanes";
            this.listBoxPlanes.Size = new System.Drawing.Size(423, 624);
            this.listBoxPlanes.TabIndex = 10;
            // 
            // MainFrame
            // 
            this.ClientSize = new System.Drawing.Size(1080, 704);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageSeats.ResumeLayout(false);
            this.tabPageSeats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSeats_ListOfPlanes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxPlanes;
    }
}
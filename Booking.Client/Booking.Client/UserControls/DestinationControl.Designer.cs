namespace Booking.Client.UserControls
{
    partial class DestinationControl
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteRoute_Button = new System.Windows.Forms.Button();
            this.RefreshDestinations = new System.Windows.Forms.Button();
            this.listBoxPlanes = new System.Windows.Forms.ListBox();
            this.comboBoxDestination_ListOfPlanes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_CreateDes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateRoute_StartDestination = new System.Windows.Forms.TextBox();
            this.LoadPlanes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Start Destination";
            // 
            // DeleteRoute_Button
            // 
            this.DeleteRoute_Button.Location = new System.Drawing.Point(873, 566);
            this.DeleteRoute_Button.Name = "DeleteRoute_Button";
            this.DeleteRoute_Button.Size = new System.Drawing.Size(99, 56);
            this.DeleteRoute_Button.TabIndex = 24;
            this.DeleteRoute_Button.Text = "Delete";
            this.DeleteRoute_Button.UseVisualStyleBackColor = true;
            this.DeleteRoute_Button.Click += new System.EventHandler(this.DeleteRoute_Button_Click);
            // 
            // RefreshDestinations
            // 
            this.RefreshDestinations.Location = new System.Drawing.Point(613, 566);
            this.RefreshDestinations.Name = "RefreshDestinations";
            this.RefreshDestinations.Size = new System.Drawing.Size(101, 56);
            this.RefreshDestinations.TabIndex = 23;
            this.RefreshDestinations.Text = "Refresh";
            this.RefreshDestinations.UseVisualStyleBackColor = true;
            this.RefreshDestinations.Click += new System.EventHandler(this.RefreshDestinations_Click);
            // 
            // listBoxPlanes
            // 
            this.listBoxPlanes.FormattingEnabled = true;
            this.listBoxPlanes.ItemHeight = 20;
            this.listBoxPlanes.Location = new System.Drawing.Point(569, 58);
            this.listBoxPlanes.Name = "listBoxPlanes";
            this.listBoxPlanes.Size = new System.Drawing.Size(468, 484);
            this.listBoxPlanes.TabIndex = 22;
            // 
            // comboBoxDestination_ListOfPlanes
            // 
            this.comboBoxDestination_ListOfPlanes.FormattingEnabled = true;
            this.comboBoxDestination_ListOfPlanes.Location = new System.Drawing.Point(38, 351);
            this.comboBoxDestination_ListOfPlanes.Name = "comboBoxDestination_ListOfPlanes";
            this.comboBoxDestination_ListOfPlanes.Size = new System.Drawing.Size(175, 28);
            this.comboBoxDestination_ListOfPlanes.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "List Of All Plane Routes: ";
            // 
            // Button_CreateDes
            // 
            this.Button_CreateDes.Location = new System.Drawing.Point(38, 566);
            this.Button_CreateDes.Name = "Button_CreateDes";
            this.Button_CreateDes.Size = new System.Drawing.Size(124, 56);
            this.Button_CreateDes.TabIndex = 19;
            this.Button_CreateDes.Text = "Create";
            this.Button_CreateDes.UseVisualStyleBackColor = true;
            this.Button_CreateDes.Click += new System.EventHandler(this.Button_CreateDes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select A Plane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "End Destination";
            // 
            // CreateRoute_StartDestination
            // 
            this.CreateRoute_StartDestination.Location = new System.Drawing.Point(38, 253);
            this.CreateRoute_StartDestination.Name = "CreateRoute_StartDestination";
            this.CreateRoute_StartDestination.Size = new System.Drawing.Size(175, 26);
            this.CreateRoute_StartDestination.TabIndex = 16;
            // 
            // LoadPlanes
            // 
            this.LoadPlanes.Location = new System.Drawing.Point(38, 397);
            this.LoadPlanes.Name = "LoadPlanes";
            this.LoadPlanes.Size = new System.Drawing.Size(124, 40);
            this.LoadPlanes.TabIndex = 27;
            this.LoadPlanes.Text = "Load Planes";
            this.LoadPlanes.UseVisualStyleBackColor = true;
            this.LoadPlanes.Click += new System.EventHandler(this.LoadPlanes_Click);
            // 
            // DestinationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoadPlanes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteRoute_Button);
            this.Controls.Add(this.RefreshDestinations);
            this.Controls.Add(this.listBoxPlanes);
            this.Controls.Add(this.comboBoxDestination_ListOfPlanes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_CreateDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateRoute_StartDestination);
            this.Name = "DestinationControl";
            this.Size = new System.Drawing.Size(1319, 828);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteRoute_Button;
        private System.Windows.Forms.Button RefreshDestinations;
        private System.Windows.Forms.ListBox listBoxPlanes;
        private System.Windows.Forms.ComboBox comboBoxDestination_ListOfPlanes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_CreateDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateRoute_StartDestination;
        private System.Windows.Forms.Button LoadPlanes;
    }
}

namespace Booking.Client.UserControls
{
    partial class PassengersControl
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
            this.listBoxPassengers = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPassengers_Planes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPassengers
            // 
            this.listBoxPassengers.FormattingEnabled = true;
            this.listBoxPassengers.ItemHeight = 20;
            this.listBoxPassengers.Location = new System.Drawing.Point(26, 104);
            this.listBoxPassengers.Name = "listBoxPassengers";
            this.listBoxPassengers.Size = new System.Drawing.Size(324, 484);
            this.listBoxPassengers.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Select a plane";
            // 
            // comboBoxPassengers_Planes
            // 
            this.comboBoxPassengers_Planes.FormattingEnabled = true;
            this.comboBoxPassengers_Planes.Location = new System.Drawing.Point(26, 47);
            this.comboBoxPassengers_Planes.Name = "comboBoxPassengers_Planes";
            this.comboBoxPassengers_Planes.Size = new System.Drawing.Size(161, 28);
            this.comboBoxPassengers_Planes.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load Planes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassengersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxPassengers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxPassengers_Planes);
            this.Name = "PassengersControl";
            this.Size = new System.Drawing.Size(1336, 816);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPassengers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPassengers_Planes;
        private System.Windows.Forms.Button button1;
    }
}

namespace Booking.Client.UserControls
{
    partial class PlaneControl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bntPlane_Update = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPlaneUpdate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Plane_CreatePlane = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.Plane_PlaneType = new System.Windows.Forms.TextBox();
            this.Plane_PlaneBox = new System.Windows.Forms.ListBox();
            this.Plane_RefreshPlaneButton = new System.Windows.Forms.Button();
            this.Plane_DeletePlane = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Plane_UpdateSeatSchema = new System.Windows.Forms.Button();
            this.Plane_UpdateRowNumber = new System.Windows.Forms.TextBox();
            this.Plane_UpdateSeatSchemaTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Plane_SeatSchemaTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Plane_CreateSeatSchema = new System.Windows.Forms.Button();
            this.Plane_RowNumber = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Plane_SeatSchema = new System.Windows.Forms.ListBox();
            this.Plane_RefreshSeatSchema = new System.Windows.Forms.Button();
            this.Plane_DeleteSeatSchema = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.Plane_PlaneBox);
            this.groupBox2.Controls.Add(this.Plane_RefreshPlaneButton);
            this.groupBox2.Controls.Add(this.Plane_DeletePlane);
            this.groupBox2.Location = new System.Drawing.Point(15, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 499);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plane";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bntPlane_Update);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtPlaneUpdate);
            this.groupBox4.Location = new System.Drawing.Point(151, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(122, 136);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit";
            // 
            // bntPlane_Update
            // 
            this.bntPlane_Update.Location = new System.Drawing.Point(10, 90);
            this.bntPlane_Update.Name = "bntPlane_Update";
            this.bntPlane_Update.Size = new System.Drawing.Size(100, 37);
            this.bntPlane_Update.TabIndex = 6;
            this.bntPlane_Update.Text = "Update";
            this.bntPlane_Update.UseVisualStyleBackColor = true;
            this.bntPlane_Update.Click += new System.EventHandler(this.bntPlane_Update_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 20);
            this.label22.TabIndex = 10;
            this.label22.Text = "Plane Type: ";
            // 
            // txtPlaneUpdate
            // 
            this.txtPlaneUpdate.Location = new System.Drawing.Point(10, 41);
            this.txtPlaneUpdate.Name = "txtPlaneUpdate";
            this.txtPlaneUpdate.Size = new System.Drawing.Size(100, 26);
            this.txtPlaneUpdate.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Plane_CreatePlane);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.Plane_PlaneType);
            this.groupBox3.Location = new System.Drawing.Point(6, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 136);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New";
            // 
            // Plane_CreatePlane
            // 
            this.Plane_CreatePlane.Location = new System.Drawing.Point(10, 90);
            this.Plane_CreatePlane.Name = "Plane_CreatePlane";
            this.Plane_CreatePlane.Size = new System.Drawing.Size(100, 37);
            this.Plane_CreatePlane.TabIndex = 6;
            this.Plane_CreatePlane.Text = "Create";
            this.Plane_CreatePlane.UseVisualStyleBackColor = true;
            this.Plane_CreatePlane.Click += new System.EventHandler(this.Plane_CreatePlane_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 20);
            this.label23.TabIndex = 10;
            this.label23.Text = "Plane Type: ";
            // 
            // Plane_PlaneType
            // 
            this.Plane_PlaneType.Location = new System.Drawing.Point(10, 41);
            this.Plane_PlaneType.Name = "Plane_PlaneType";
            this.Plane_PlaneType.Size = new System.Drawing.Size(100, 26);
            this.Plane_PlaneType.TabIndex = 9;
            // 
            // Plane_PlaneBox
            // 
            this.Plane_PlaneBox.FormattingEnabled = true;
            this.Plane_PlaneBox.ItemHeight = 20;
            this.Plane_PlaneBox.Location = new System.Drawing.Point(6, 21);
            this.Plane_PlaneBox.Name = "Plane_PlaneBox";
            this.Plane_PlaneBox.Size = new System.Drawing.Size(200, 264);
            this.Plane_PlaneBox.TabIndex = 2;
            this.Plane_PlaneBox.SelectedIndexChanged += new System.EventHandler(this.Plane_PlaneBox_SelectedIndexChanged);
            // 
            // Plane_RefreshPlaneButton
            // 
            this.Plane_RefreshPlaneButton.Location = new System.Drawing.Point(212, 21);
            this.Plane_RefreshPlaneButton.Name = "Plane_RefreshPlaneButton";
            this.Plane_RefreshPlaneButton.Size = new System.Drawing.Size(97, 64);
            this.Plane_RefreshPlaneButton.TabIndex = 14;
            this.Plane_RefreshPlaneButton.Text = "Refresh";
            this.Plane_RefreshPlaneButton.UseVisualStyleBackColor = true;
            this.Plane_RefreshPlaneButton.Click += new System.EventHandler(this.Plane_RefreshPlaneButton_Click);
            // 
            // Plane_DeletePlane
            // 
            this.Plane_DeletePlane.Location = new System.Drawing.Point(212, 91);
            this.Plane_DeletePlane.Name = "Plane_DeletePlane";
            this.Plane_DeletePlane.Size = new System.Drawing.Size(97, 60);
            this.Plane_DeletePlane.TabIndex = 8;
            this.Plane_DeletePlane.Text = "Delete";
            this.Plane_DeletePlane.UseVisualStyleBackColor = true;
            this.Plane_DeletePlane.Click += new System.EventHandler(this.Plane_DeletePlane_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.Plane_SeatSchema);
            this.groupBox1.Controls.Add(this.Plane_RefreshSeatSchema);
            this.groupBox1.Controls.Add(this.Plane_DeleteSeatSchema);
            this.groupBox1.Location = new System.Drawing.Point(488, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 499);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Row Schemas";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Plane_UpdateSeatSchema);
            this.groupBox6.Controls.Add(this.Plane_UpdateRowNumber);
            this.groupBox6.Controls.Add(this.Plane_UpdateSeatSchemaTextBox);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Location = new System.Drawing.Point(261, 339);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 154);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Edit";
            // 
            // Plane_UpdateSeatSchema
            // 
            this.Plane_UpdateSeatSchema.Location = new System.Drawing.Point(81, 97);
            this.Plane_UpdateSeatSchema.Name = "Plane_UpdateSeatSchema";
            this.Plane_UpdateSeatSchema.Size = new System.Drawing.Size(75, 35);
            this.Plane_UpdateSeatSchema.TabIndex = 18;
            this.Plane_UpdateSeatSchema.Text = "Update";
            this.Plane_UpdateSeatSchema.UseVisualStyleBackColor = true;
            this.Plane_UpdateSeatSchema.Click += new System.EventHandler(this.Plane_UpdateSeatSchema_Click);
            // 
            // Plane_UpdateRowNumber
            // 
            this.Plane_UpdateRowNumber.Location = new System.Drawing.Point(118, 54);
            this.Plane_UpdateRowNumber.Name = "Plane_UpdateRowNumber";
            this.Plane_UpdateRowNumber.Size = new System.Drawing.Size(100, 26);
            this.Plane_UpdateRowNumber.TabIndex = 20;
            this.Plane_UpdateRowNumber.TextChanged += new System.EventHandler(this.Plane_RowNumber_TextChanged);
            this.Plane_UpdateRowNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Plane_RowNumber_KeyPress);
            // 
            // Plane_UpdateSeatSchemaTextBox
            // 
            this.Plane_UpdateSeatSchemaTextBox.Location = new System.Drawing.Point(118, 22);
            this.Plane_UpdateSeatSchemaTextBox.Name = "Plane_UpdateSeatSchemaTextBox";
            this.Plane_UpdateSeatSchemaTextBox.Size = new System.Drawing.Size(100, 26);
            this.Plane_UpdateSeatSchemaTextBox.TabIndex = 18;
            this.Plane_UpdateSeatSchemaTextBox.TextChanged += new System.EventHandler(this.Plane_SeatSchemaTextBox_TextChanged);
            this.Plane_UpdateSeatSchemaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Plane_SeatSchemaTextBox_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 20);
            this.label26.TabIndex = 19;
            this.label26.Text = "Row Number";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 20);
            this.label25.TabIndex = 18;
            this.label25.Text = "Seat Schema";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Plane_SeatSchemaTextBox);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.Plane_CreateSeatSchema);
            this.groupBox5.Controls.Add(this.Plane_RowNumber);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Location = new System.Drawing.Point(9, 339);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 154);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "New";
            // 
            // Plane_SeatSchemaTextBox
            // 
            this.Plane_SeatSchemaTextBox.Location = new System.Drawing.Point(118, 22);
            this.Plane_SeatSchemaTextBox.Name = "Plane_SeatSchemaTextBox";
            this.Plane_SeatSchemaTextBox.Size = new System.Drawing.Size(100, 26);
            this.Plane_SeatSchemaTextBox.TabIndex = 12;
            this.Plane_SeatSchemaTextBox.TextChanged += new System.EventHandler(this.Plane_SeatSchemaTextBox_TextChanged);
            this.Plane_SeatSchemaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Plane_SeatSchemaTextBox_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 20);
            this.label21.TabIndex = 17;
            this.label21.Text = "Row Number";
            // 
            // Plane_CreateSeatSchema
            // 
            this.Plane_CreateSeatSchema.Location = new System.Drawing.Point(80, 97);
            this.Plane_CreateSeatSchema.Name = "Plane_CreateSeatSchema";
            this.Plane_CreateSeatSchema.Size = new System.Drawing.Size(75, 35);
            this.Plane_CreateSeatSchema.TabIndex = 5;
            this.Plane_CreateSeatSchema.Text = "Create";
            this.Plane_CreateSeatSchema.UseVisualStyleBackColor = true;
            this.Plane_CreateSeatSchema.Click += new System.EventHandler(this.Plane_CreateSeatSchema_Click);
            // 
            // Plane_RowNumber
            // 
            this.Plane_RowNumber.Location = new System.Drawing.Point(118, 54);
            this.Plane_RowNumber.Name = "Plane_RowNumber";
            this.Plane_RowNumber.Size = new System.Drawing.Size(100, 26);
            this.Plane_RowNumber.TabIndex = 16;
            this.Plane_RowNumber.TextChanged += new System.EventHandler(this.Plane_RowNumber_TextChanged);
            this.Plane_RowNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Plane_RowNumber_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 20);
            this.label24.TabIndex = 13;
            this.label24.Text = "Seat Schema";
            // 
            // Plane_SeatSchema
            // 
            this.Plane_SeatSchema.FormattingEnabled = true;
            this.Plane_SeatSchema.ItemHeight = 20;
            this.Plane_SeatSchema.Location = new System.Drawing.Point(9, 21);
            this.Plane_SeatSchema.Name = "Plane_SeatSchema";
            this.Plane_SeatSchema.Size = new System.Drawing.Size(230, 304);
            this.Plane_SeatSchema.TabIndex = 3;
            this.Plane_SeatSchema.SelectedIndexChanged += new System.EventHandler(this.Plane_SeatSchema_SelectedIndexChanged);
            // 
            // Plane_RefreshSeatSchema
            // 
            this.Plane_RefreshSeatSchema.Location = new System.Drawing.Point(261, 21);
            this.Plane_RefreshSeatSchema.Name = "Plane_RefreshSeatSchema";
            this.Plane_RefreshSeatSchema.Size = new System.Drawing.Size(107, 64);
            this.Plane_RefreshSeatSchema.TabIndex = 15;
            this.Plane_RefreshSeatSchema.Text = "Refresh Seat Schema";
            this.Plane_RefreshSeatSchema.UseVisualStyleBackColor = true;
            this.Plane_RefreshSeatSchema.Click += new System.EventHandler(this.Plane_RefreshSeatSchema_Click);
            // 
            // Plane_DeleteSeatSchema
            // 
            this.Plane_DeleteSeatSchema.Location = new System.Drawing.Point(261, 91);
            this.Plane_DeleteSeatSchema.Name = "Plane_DeleteSeatSchema";
            this.Plane_DeleteSeatSchema.Size = new System.Drawing.Size(107, 60);
            this.Plane_DeleteSeatSchema.TabIndex = 7;
            this.Plane_DeleteSeatSchema.Text = "Delete";
            this.Plane_DeleteSeatSchema.UseVisualStyleBackColor = true;
            this.Plane_DeleteSeatSchema.Click += new System.EventHandler(this.Plane_DeleteSeatSchema_Click);
            // 
            // PlaneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PlaneControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1078, 674);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bntPlane_Update;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPlaneUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Plane_CreatePlane;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox Plane_PlaneType;
        private System.Windows.Forms.ListBox Plane_PlaneBox;
        private System.Windows.Forms.Button Plane_RefreshPlaneButton;
        private System.Windows.Forms.Button Plane_DeletePlane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Plane_UpdateSeatSchema;
        private System.Windows.Forms.TextBox Plane_UpdateRowNumber;
        private System.Windows.Forms.TextBox Plane_UpdateSeatSchemaTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Plane_SeatSchemaTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Plane_CreateSeatSchema;
        private System.Windows.Forms.TextBox Plane_RowNumber;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ListBox Plane_SeatSchema;
        private System.Windows.Forms.Button Plane_RefreshSeatSchema;
        private System.Windows.Forms.Button Plane_DeleteSeatSchema;
    }
}

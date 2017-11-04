namespace TestUIDesgin
{
    partial class APLSEM3Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APLSEM3Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.DataReadbutton = new System.Windows.Forms.Button();
            this.Calibrationbutton = new System.Windows.Forms.Button();
            this.Connectionbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.userControl11 = new TestUIDesgin.UserControl1();
            this.connectionControl1 = new TestUIDesgin.ConnectionControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SideBarPanel);
            this.panel1.Controls.Add(this.DataReadbutton);
            this.panel1.Controls.Add(this.Calibrationbutton);
            this.panel1.Controls.Add(this.Connectionbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 526);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestUIDesgin.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SideBarPanel.Location = new System.Drawing.Point(0, 99);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(10, 81);
            this.SideBarPanel.TabIndex = 3;
            // 
            // DataReadbutton
            // 
            this.DataReadbutton.FlatAppearance.BorderSize = 0;
            this.DataReadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataReadbutton.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataReadbutton.ForeColor = System.Drawing.Color.White;
            this.DataReadbutton.Image = global::TestUIDesgin.Properties.Resources.point_of_service;
            this.DataReadbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataReadbutton.Location = new System.Drawing.Point(13, 267);
            this.DataReadbutton.Name = "DataReadbutton";
            this.DataReadbutton.Size = new System.Drawing.Size(188, 82);
            this.DataReadbutton.TabIndex = 3;
            this.DataReadbutton.Text = "  Data Read";
            this.DataReadbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataReadbutton.UseVisualStyleBackColor = true;
            this.DataReadbutton.Click += new System.EventHandler(this.DataReadbutton_Click);
            // 
            // Calibrationbutton
            // 
            this.Calibrationbutton.FlatAppearance.BorderSize = 0;
            this.Calibrationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calibrationbutton.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calibrationbutton.ForeColor = System.Drawing.Color.White;
            this.Calibrationbutton.Image = global::TestUIDesgin.Properties.Resources.calibre1;
            this.Calibrationbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calibrationbutton.Location = new System.Drawing.Point(13, 183);
            this.Calibrationbutton.Name = "Calibrationbutton";
            this.Calibrationbutton.Size = new System.Drawing.Size(188, 81);
            this.Calibrationbutton.TabIndex = 3;
            this.Calibrationbutton.Text = "  Calibration";
            this.Calibrationbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Calibrationbutton.UseVisualStyleBackColor = true;
            this.Calibrationbutton.Click += new System.EventHandler(this.Calibrationbutton_Click);
            // 
            // Connectionbutton
            // 
            this.Connectionbutton.FlatAppearance.BorderSize = 0;
            this.Connectionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connectionbutton.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connectionbutton.ForeColor = System.Drawing.Color.White;
            this.Connectionbutton.Image = global::TestUIDesgin.Properties.Resources.universal_serial_usb_connector;
            this.Connectionbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Connectionbutton.Location = new System.Drawing.Point(13, 99);
            this.Connectionbutton.Name = "Connectionbutton";
            this.Connectionbutton.Size = new System.Drawing.Size(188, 81);
            this.Connectionbutton.TabIndex = 3;
            this.Connectionbutton.Text = "  Connection";
            this.Connectionbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Connectionbutton.UseVisualStyleBackColor = true;
            this.Connectionbutton.Click += new System.EventHandler(this.Connectionbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.MinimizeButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 35);
            this.panel2.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Location = new System.Drawing.Point(649, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 23);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Extrabold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(277, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "APLSEM v3.0";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(676, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(204, 32);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(705, 494);
            this.userControl11.TabIndex = 2;
            // 
            // connectionControl1
            // 
            this.connectionControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectionControl1.BackgroundImage")));
            this.connectionControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectionControl1.Location = new System.Drawing.Point(204, 32);
            this.connectionControl1.Name = "connectionControl1";
            this.connectionControl1.Size = new System.Drawing.Size(705, 494);
            this.connectionControl1.TabIndex = 3;
            this.connectionControl1.Load += new System.EventHandler(this.connectionControl1_Load);
            // 
            // APLSEM3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(909, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.connectionControl1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "APLSEM3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APLSEM30";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Connectionbutton;
        private System.Windows.Forms.Button DataReadbutton;
        private System.Windows.Forms.Button Calibrationbutton;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button MinimizeButton;
        private ConnectionControl connectionControl1;
    }
}


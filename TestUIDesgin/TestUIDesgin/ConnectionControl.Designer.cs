namespace TestUIDesgin
{
    partial class ConnectionControl
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ConnectPortButton = new System.Windows.Forms.Button();
            this.ScanPort = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SelectPortLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnectPortButton
            // 
            this.ConnectPortButton.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectPortButton.Location = new System.Drawing.Point(176, 261);
            this.ConnectPortButton.Name = "ConnectPortButton";
            this.ConnectPortButton.Size = new System.Drawing.Size(174, 50);
            this.ConnectPortButton.TabIndex = 0;
            this.ConnectPortButton.Text = "Connect";
            this.ConnectPortButton.UseVisualStyleBackColor = true;
            this.ConnectPortButton.Click += new System.EventHandler(this.ConnectPortButton_Click);
            // 
            // ScanPort
            // 
            this.ScanPort.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanPort.Location = new System.Drawing.Point(176, 185);
            this.ScanPort.Name = "ScanPort";
            this.ScanPort.Size = new System.Drawing.Size(115, 58);
            this.ScanPort.TabIndex = 0;
            this.ScanPort.Text = "Scan Port";
            this.ScanPort.UseVisualStyleBackColor = true;
            this.ScanPort.Click += new System.EventHandler(this.ScanPort_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectButton.Location = new System.Drawing.Point(363, 261);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(174, 50);
            this.DisconnectButton.TabIndex = 0;
            this.DisconnectButton.Text = "Disconnet";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(422, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // SelectPortLabel
            // 
            this.SelectPortLabel.AutoSize = true;
            this.SelectPortLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectPortLabel.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPortLabel.Location = new System.Drawing.Point(297, 180);
            this.SelectPortLabel.Name = "SelectPortLabel";
            this.SelectPortLabel.Size = new System.Drawing.Size(120, 28);
            this.SelectPortLabel.TabIndex = 2;
            this.SelectPortLabel.Text = "Select Port";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1600",
            "2400",
            "4800",
            "9600"});
            this.comboBox2.Location = new System.Drawing.Point(422, 222);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baud Rate";
            // 
            // ConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestUIDesgin.Properties.Resources._3a64d992ee0c00791466cdba896f57aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectPortLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ScanPort);
            this.Controls.Add(this.ConnectPortButton);
            this.Name = "ConnectionControl";
            this.Size = new System.Drawing.Size(705, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ConnectPortButton;
        private System.Windows.Forms.Button ScanPort;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label SelectPortLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}

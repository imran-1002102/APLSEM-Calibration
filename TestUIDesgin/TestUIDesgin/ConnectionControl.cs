using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TestUIDesgin
{
    public partial class ConnectionControl : UserControl
    {
        public ConnectionControl()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 3;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            DisconnectButton.Enabled = false;
        }

        private void ScanPort_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] availablePorts = SerialPort.GetPortNames();
            foreach (string port in availablePorts)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void ConnectPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
                serialPort1.PortName = selectedPort;
                serialPort1.BaudRate = Int32.Parse(comboBox2.GetItemText(comboBox2.SelectedItem));
                if (0 == comboBox3.SelectedIndex)
                {
                    serialPort1.Parity = Parity.Even;
                }
                if (1 == comboBox3.SelectedIndex)
                {
                    serialPort1.Parity = Parity.Odd;
                }
                if (2 == comboBox3.SelectedIndex)
                {
                    serialPort1.Parity = Parity.None;
                }

                if (0 == comboBox4.SelectedIndex)
                {
                    serialPort1.StopBits = StopBits.One;
                }
                if (1 == comboBox4.SelectedIndex)
                {
                    serialPort1.StopBits = StopBits.Two;
                }
                serialPort1.Open();
                ConnectPortButton.Text = "Connected";
                ConnectPortButton.Enabled = false;
                DisconnectButton.Enabled = true;

                UserControl1 myUserControlObject = new UserControl1();
                myUserControlObject.SetSerialPort(serialPort1);
            }
            catch (Exception serialPortException)
            {
                MessageBox.Show("Can't Find Serial Port!");
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            ConnectPortButton.Text = "Connect";
            try
            {
                serialPort1.Close();
                ConnectPortButton.Enabled = true;
                DisconnectButton.Enabled = false;
            }
            catch (Exception serialPortException)
            {
                MessageBox.Show("Can't Find Serial Port!");
            }
        }
        
    }
}

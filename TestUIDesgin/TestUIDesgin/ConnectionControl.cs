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
                
                // serialPort1.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

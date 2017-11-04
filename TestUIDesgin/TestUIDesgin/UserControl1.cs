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
    public partial class UserControl1 : UserControl
    {
        SerialPort serialPort;
        public UserControl1()
        {
            InitializeComponent();
        }

        public void SetSerialPort(SerialPort port)
        {
            serialPort = port;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PhaseCurrentReadButton_Click(object sender, EventArgs e)
        {
            byte[] voltageRead = {0xfe, 0xfe};
            try
            {
                serialPort.Write(voltageRead, 0, voltageRead.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't find serial port");
                MessageBox.Show(serialPort.PortName);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUIDesgin
{
    public partial class APLSEM3Form : Form
    {
        public APLSEM3Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Connectionbutton_Click(object sender, EventArgs e)
        {
            SideBarPanel.Top = Connectionbutton.Top;
            connectionControl1.BringToFront();
        }

        private void Calibrationbutton_Click(object sender, EventArgs e)
        {
            SideBarPanel.Top = Calibrationbutton.Top;
        }

        private void DataReadbutton_Click(object sender, EventArgs e)
        {
            SideBarPanel.Top = DataReadbutton.Top;
            userControl11.BringToFront();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

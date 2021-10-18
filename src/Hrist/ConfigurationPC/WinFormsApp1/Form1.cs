using System;
using System.Management;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\cimv2", "select * from win32_videocontroller");
            ManagementObjectCollection moc = mos.Get();

            foreach (ManagementObject mo in moc)
            {
                label1.Text = mo.GetPropertyValue("Name").ToString();
            }
        }
    }
}

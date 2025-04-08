using System;
using System.Windows.Forms;

namespace Traffic_Light_Uc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uc_Traffic_Light1_OnGreen(object sender, TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void uc_Traffic_Light1_OnOrange(object sender, TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void uc_Traffic_Light1_OnRed(object sender, TrafficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc_Traffic_Light1.Start();
        }
    }
}

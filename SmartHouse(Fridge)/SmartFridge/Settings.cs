using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFridge
{
    public partial class Settings : Form
    {
        bool flag = false;

        public Settings()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_temp.Text = hScrollBar1.Value.ToString() + " C";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            FridgeSoftware.Settings.SetDate(dateTimePicker1.Value);
            FridgeSoftware.Settings.SetTemprature(hScrollBar1.Value);
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btn_OnOff_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                btn_OnOff.Text = "Set On";
                lbl_network.Text = "Wifi is Off";
            }
            else
            {
                flag = true;
                btn_OnOff.Text = "Set Off";
                lbl_network.Text = "Wifi is On";
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            FridgeSoftware.Help.Show(4);
            Help help = new Help();
            help.Show();
        }
    }
}

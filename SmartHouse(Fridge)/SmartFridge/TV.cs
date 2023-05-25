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
    public partial class TV : Form
    {
        public TV()
        {
            InitializeComponent();
            Close_Tv();
        }

        private void btn_Off_Click(object sender, EventArgs e)
        {
            pl_TV.BackColor = Color.Black;
            Close_Tv();
        }

        private void btn_on_Click(object sender, EventArgs e)
        {
            pl_TV.BackColor = Color.Blue;
            pc_NetFlix.Show();
            pc_YouTube.Show();
            pc_securityCamera.Show();
        }

        private void Close_Tv()
        {
            pc_NetFlix.Hide();
            pc_YouTube.Hide();
            pc_securityCamera.Hide();
            webBrowser1.Hide();
        }

        private void TV_Load(object sender, EventArgs e)
        {
            Close_Tv();
        }

        private void pc_YouTube_Click(object sender, EventArgs e)
        {
            var uri = "https://www.youtube.com/";
            webBrowser1.Navigate(uri);
            webBrowser1.Show();
        }

        private void pc_NetFlix_Click(object sender, EventArgs e)
        {
            var uri = "https://www.netflix.com/gr/";
            webBrowser1.Navigate(uri);
            webBrowser1.Show();
        }

        private void pc_securityCamera_Click(object sender, EventArgs e)
        {
            var uri = "https://www.dropbox.com/s/o2c1mnd6228ugtm/securityCamera.jpg?dl=0";
            webBrowser1.Navigate(uri);
            webBrowser1.Show();
        }

        private void btn__Click(object sender, EventArgs e)
        {
            webBrowser1.Hide();
        }

        private void info_Click(object sender, EventArgs e)
        {
            FridgeSoftware.Help.Show(5);
            Help help = new Help();
            help.Show();
        }
    }
}

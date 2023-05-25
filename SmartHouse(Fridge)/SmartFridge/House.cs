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
    public partial class House : Form
    {
        public House()
        {
            InitializeComponent();
            pc_light_on_salon.Hide();
        }

        private void btn_Fridge_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pc_light_off_salon_Click(object sender, EventArgs e)
        {
            pc_light_off_salon.Hide();
            pc_light_on_salon.Show();
        }

        private void pc_light_on_salon_Click(object sender, EventArgs e)
        {
            pc_light_off_salon.Show();
            pc_light_on_salon.Hide();
        }

        private void pc_light_off_kichen_Click(object sender, EventArgs e)
        {
            pc_light_off_kichen.Hide();
            pc_light_on_kichen.Show();
        }

        private void pc_light_on_kichen_Click(object sender, EventArgs e)
        {
            pc_light_off_kichen.Show();
            pc_light_on_kichen.Hide();
        }

        private void btn_television_Click(object sender, EventArgs e)
        {
            TV tv = new TV();
            tv.Show();
        }
    }
}

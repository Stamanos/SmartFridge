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
    public partial class Shopping : Form
    {
        public static int chartProducts = 0;
        public Shopping()
        {
            InitializeComponent();
        }
        private void Shopping_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method make the pictureBox that we insert with a clicky efect and reset the others
        /// </summary>
        /// <param name="shop"></param>
        private void ChooseShop(PictureBox shop)
        {
            pb_AB.BorderStyle = BorderStyle.None;
            pb_carfour.BorderStyle = BorderStyle.None;
            pb_marinopoulos.BorderStyle = BorderStyle.None;
            pb_sklavenitis.BorderStyle = BorderStyle.None;
            pb_veropoulos.BorderStyle = BorderStyle.None;
            if (shop.BorderStyle == BorderStyle.None)
            {
                shop.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                shop.BorderStyle = BorderStyle.None;
            }
        }

        private void pb_veropoulos_Click(object sender, EventArgs e)
        {
            ChooseShop(pb_veropoulos);
        }

        private void pb_sklavenitis_Click(object sender, EventArgs e)
        {
            ChooseShop(pb_sklavenitis);
        }

        private void pb_marinopoulos_Click(object sender, EventArgs e)
        {
            ChooseShop(pb_marinopoulos);
        }

        private void pb_AB_Click(object sender, EventArgs e)
        {
            ChooseShop(pb_AB);
        }

        private void pb_carfour_Click(object sender, EventArgs e)
        {
            ChooseShop(pb_carfour);
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            foreach(var item in clb_Type.CheckedItems)
            {
                try
                {
                    FridgeSoftware.Shop.Add(item.ToString(), Convert.ToInt32(rtb_quantity.Text));
                    lbl_Chart.Text = FridgeSoftware.Shop.products.Sum(x => x.Value).ToString();
                    //rtb_quantity.ResetText(); //reset the value to null
                }
                catch(FormatException exception)//If the user put character besides number
                {
                    MessageBox.Show("Παρακαλώ εισάγεται Αριθμό στο κουτί");
                }
            }
        }

        private void meat_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Φρέσκο κρέας";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Χοιρινό",
            "Μοσχαρίσιο",
            "Κοτόπουλο",
            "Γαλοπούλα",
            "Αρνίσιο",
            "Κουνέλι",
            "Χήνα"});
        }

        private void salty_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Αλαντικά";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Λουκάνικα",
            "Πάριζα",
            "Ζαμπόν",
            "Πουλερικά",
            "Μπέικον"});
        }

        private void ζυμαρικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Ζυμαρικά";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Πένες",
            "Σπαγγέτι",
            "Κανελόνια",
            "Βιδες",
            "Τορτελίνια",
            "Κοχυλάκια",
            "Ρύζι"});
        }

        private void φρούταToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Φρούτα";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Μπανάνα",
            "Βύσσινο",
            "Πασιφλόρα",
            "Ρόδι",
            "Σταφύλι",
            "Σύκο",
            "Λεμόνι",
            "Κυδώνι",
            "Ανανάς",
            "Μήλο",
            "Αχλάδι",
            "Ακτινίδιο",
            "Αβοκάντο"});
        }

        private void λαχανικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Λαχανικά";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Αγκινάρα",
            "Αγγούρι",
            "Καλαμπόκι",
            "Κολοκυθάκι",
            "Κουνουπίδι",
            "Κρεμμύδι",
            "Λάχανο",
            "Μελιτζάνα",
            "Μπάμια",
            "Μπρόκολο",
            "Παντζάρι",
            "Πατάτα",
            "Πράσο",
            "Πιπεριά",
            "Καλαμπόκι",
            "Σέλινο",
            "Μαϊντανός",
            "Σκόρδο",
            "Σπανάκι",
            "Σπαράγγι",
            "Ντομάτα",
            "Πιπεριά"});
        }

        private void έτοιμεςΣαλάτεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Έτοιμες Σαλάτες";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Κρητική",
            "Ντάκος",
            "Χοριάτικη",
            "Του Καίσαρα",
            "Του Σεφ",
            "Λάχανο καρότο",
            "Πολίτικη"});
        }

        private void κρέμεςΓάλαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Κρέμες Γάλακτος";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Γιαούρτι",
            "Γάλα άσπρο",
            "Σοκολατούχο",
            "Κρέμες γλυκιές",
            "κρέμες Γάλακτος"});
        }

        private void τυριάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Τυριά";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Φέτα",
            "Ανθότυρος",
            "Γραβιέρα",
            "Παρμεζάνα",
            "Μοτσαρέλα",
            "Κασέρι",
            "Τσένταρ",
            "Τυρί κρέμα",
            "Τσένταρ"});
        }

        private void αλοιφέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Αλοιφές";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Κέτσαπ",
            "Μουστάρδα",
            "Μαγιονέζα",
            "Μπάρμπεκιου",
            "Σος"});
        }

        private void κονσέρβεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Κονσέρβες";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Ντοματοπελτές",
            "Φασόλια",
            "Μανιτάρια",
            "Τόνος"});
        }

        private void ζαχαροπλαστικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Ζαχαροπλαστική";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Βανίλια",
            "Μπέικιν πάουντερ",
            "Αλέυρι",
            "Ζάχαρη",
            "Ζάχαρη άχνη",
            "Παγωτό",
            "Βανίλια",
            "Σιρόπι",
            "Μέλι",
            "Κακάο",
            "Κουβερτούρα"});
        }

        private void αναψυκτικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Αναψυκτικά";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Coca Cola",
            "Fanta",
            "RedBull",
            "Monster",
            "Μπιράλ"});
        }

        private void λιχουδιέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Λιχουδιές";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Lacta",
            "Πατατάκια",
            "ΠοπΚορν",
            "Φουντούνια"});
        }

        private void lbl_Chart_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
        }

        private void μπαχαρικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Type.Text = "Μπαχαρικά - Λάδια";
            clb_Type.Items.Clear();
            clb_Type.Items.AddRange(new object[] {
            "Πιπέρι",
            "Αλάτι",
            "Θυμάρι",
            "Ρίγανη",
            "Κάππαρη",
            "Ελιές",
            "Λάδι",
            "Βούτυρο",
            "Φυστικοβούτυρο"});
        }

        private void info_Click(object sender, EventArgs e)
        {
            FridgeSoftware.Help.Show(1);
            Help help = new Help();
            help.Show();
        }
    }
}

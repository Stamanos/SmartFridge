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
    public partial class Form1 : Form
    {
        TableLayoutPanel currentDataView;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_time.Text = FridgeSoftware.Settings.fridgeDate;
            lbl_temprature.Text = FridgeSoftware.Settings.fridgeTemprature;
            note.Text = "Please write a note";
            monthCalendar1.Hide();
            note.Hide();
            lbl_RQ.Hide();
            webBrowser.Hide();
            FridgeSoftware.Shop.startingProducts(); //to fill the Fridge with the existing products
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            if (calendar.BackColor == Color.Blue)
            {
                monthCalendar1.Hide();
            }
            else
            {
                monthCalendar1.Show();
            }
            ButtonsPressed(calendar);
        }

        private void notes_Click(object sender, EventArgs e)
        {
            if (notes.BackColor == Color.Blue)
            {
                note.Hide();
                try
                {
                    currentDataView.Hide();
                }
                catch(NullReferenceException ex)
                {
                    //That means no one note has been created
                }
            }
            else
            {
                note.Show();
                try
                {
                    currentDataView.Show();
                }
                catch (NullReferenceException ex)
                {
                    //That means no one note has been created
                }
            }
            ButtonsPressed(notes);
        }

        private void shopping_Click(object sender, EventArgs e)
        {
            ButtonsPressed(pc_shopping);
            Shopping shopping = new Shopping();
            shopping.Show();
        }

        private void discound_Click(object sender, EventArgs e)
        {
            ButtonsPressed(discound);
            if (discound.BackColor == Color.Blue) { webBrowser.Show(); }
            else { webBrowser.Hide(); }

            webBrowser.Url = new Uri("https://www.ab.gr/promotions/liflet/");
        }

        private void weather_Click(object sender, EventArgs e)
        {
            ButtonsPressed(weather);
            if(weather.BackColor == Color.Blue) { webBrowser.Show(); }
            else { webBrowser.Hide(); }
            
            webBrowser.Url = new Uri("https://www.google.de/search?rlz=1C1EKKP_enGR732GR732&ei=RCUsWou2GMSRsAfZ5JXACQ&q=weather");
        }

        private void barcode_Click(object sender, EventArgs e)
        {
            if (barcode.BackColor == Color.Blue)
            {
                lbl_RQ.Hide();
            }
            else
            {
                lbl_RQ.Show();
            }
            ButtonsPressed(barcode);
        }

        private void ButtonsPressed(PictureBox pic)
        {
            if (pic.BackColor == Color.Blue)
            {
                pic.BackColor = Color.Gray;
            }
            else
            {
                pic.BackColor = Color.Blue;
            }
        }

        private void btn_confirmed_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateBasicTableView(TableLayoutPanel notePanel)
        {
            notePanel.BackColor = Color.Gold;
            notePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            notePanel.ColumnCount = 2;
            notePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            notePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            notePanel.Location = new Point(3, 3);
            notePanel.Name = "notePanel";
            notePanel.RowCount = 1;
            notePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            notePanel.TabIndex = 0;
            notePanel.Dock = DockStyle.Top;
            notePanel.Click += new EventHandler(notePanel_click);
        }

        private void notePanel_click(object sender, EventArgs e)
        {
            TableLayoutPanel tlp = (TableLayoutPanel)sender;
            int row = FridgeSoftware.GetRowIndex(tlp.Height, tlp.GetRowHeights(), tlp.PointToClient(Cursor.Position));
            string key = FridgeSoftware.Note.noteFile.Keys.ElementAt(row - 1);
            DialogResult dialogResult = MessageBox.Show(FridgeSoftware.Note.noteFile[key], "Delete Selected Note", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FridgeSoftware.Note.Erase(key);
                notes_Refresh();

            }
            else if (dialogResult == DialogResult.No)
            {
                //Nothing
            }
        }

        public void CreateTableView(int numbOfRows, Dictionary<string, string> dictData)
        {
            TableLayoutPanel notePanel = new TableLayoutPanel();
            CreateBasicTableView(notePanel);

            notePanel.RowCount = numbOfRows;
            notePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            notePanel.Controls.Add(new Label() { Text = "Creation Date" }, 0, 0);
            notePanel.Controls.Add(new Label() { Text =  "Name"}, 1, 0);
            int row = 1;
            foreach (var key in dictData.Keys)
            {
                notePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                notePanel.Controls.Add(new Label() { Text = key }, 0, row); //Date
                notePanel.Controls.Add(new Label() { Text = dictData[key]}, 1, row); //Note
                row++;
            }
            notePanel.Size = new Size(504, (numbOfRows + 1) * 50);
            pl_results.Controls.Add(notePanel);
            currentDataView = notePanel;
        }

        private void notes_Refresh()
        {
            if (currentDataView != null)
            {
                currentDataView.DoubleClick -= notePanel_click;
                pl_results.Controls.Remove(currentDataView);
                currentDataView.Dispose();
            }
            CreateTableView(FridgeSoftware.Note.noteFile.Count, FridgeSoftware.Note.noteFile);
        }

        private void inside_Click(object sender, EventArgs e)
        {
            ButtonsPressed(pc_inside);
            InsideTheFridge inside = new InsideTheFridge();
            inside.Show();
        }

        private void recipe_Click(object sender, EventArgs e)
        {
            ButtonsPressed(recipe);
            Recipes recipes = new Recipes();
            recipes.Show();
        }

        private void note_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult dialogResult = MessageBox.Show(FridgeSoftware.Note.SMS(note.Text), "Note", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FridgeSoftware.Note.Create(note.Text, DateTime.Now.ToString("yy:mm:dd:hh:mm:ss tt"));
                    notes_Refresh();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Nothing
                }
                note.Text = ""; //reset the note
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            FridgeSoftware.Help.Show(0);
            Help help = new Help();
            help.Show();
        }

        private void pc_Settings_Click(object sender, EventArgs e)
        {
            ButtonsPressed(pc_Settings);
            Settings settings = new Settings();
            settings.Show();
            lbl_time.Text = FridgeSoftware.Settings.fridgeDate;
            lbl_temprature.Text = FridgeSoftware.Settings.fridgeTemprature;
        }
    }
}

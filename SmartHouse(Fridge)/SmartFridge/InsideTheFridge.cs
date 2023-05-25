using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartFridge
{
    public partial class InsideTheFridge : Form
    {
        TableLayoutPanel currentDataView;

        public InsideTheFridge()
        {
            InitializeComponent();
        }

        private void InsideTheFridge_Load(object sender, EventArgs e)
        {
            lbl_temprature.Text = "Temrature:          " + FridgeSoftware.Settings.fridgeTemprature + "          ";
            CreateTableView(FridgeSoftware.Shop.existingProducts.Count, FridgeSoftware.Shop.existingProducts);
            try
            {
                progressBar.Value = FridgeSoftware.Shop.existingProducts.Sum(x => x.Value);
                lbl_percentage.Text = progressBar.Value.ToString() + "/100";
            }
            catch (ArgumentOutOfRangeException excep)// if the fridge can take more products
            {

            }
        }

        private void CreateBasicTableView(TableLayoutPanel insidePanel)
        {
            insidePanel.BackColor = Color.AliceBlue;//This color for Fi-Cool-a bitches
            insidePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            insidePanel.ColumnCount = 2;
            insidePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            insidePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            insidePanel.Location = new Point(4, 4);
            insidePanel.Name = "insidePanel";
            insidePanel.RowCount = 1;
            insidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            insidePanel.TabIndex = 0;
            insidePanel.Dock = DockStyle.Top;
        }

        public void CreateTableView(int numbOfRows, Dictionary<string, int> dictData)
        {
            TableLayoutPanel insidePanel = new TableLayoutPanel();
            CreateBasicTableView(insidePanel);

            insidePanel.RowCount = numbOfRows;
            insidePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            insidePanel.Controls.Add(new Label() { Text = "Product" }, 0, 0);
            insidePanel.Controls.Add(new Label() { Text = "Quantity" }, 1, 0);
            int row = 1;
            foreach (var key in dictData.Keys)
            {
                insidePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                insidePanel.Controls.Add(new Label() { Text = key }, 0, row); //Date
                insidePanel.Controls.Add(new Label() { Text = dictData[key].ToString()}, 1, row); //Note
                row++;
            }
            insidePanel.Size = new Size(504, (numbOfRows + 1) * 50);
            pl_inside.Controls.Add(insidePanel);
            currentDataView = insidePanel;
        }

        private void btn_GoToRecipes_Click(object sender, EventArgs e)
        {
            Recipes recipes = new Recipes();
            recipes.Show();
        }

        private void btn_GoForShopping_Click(object sender, EventArgs e)
        {
            Shopping shopping = new Shopping();
            shopping.Show();
        }

        private void info_Click(object sender, EventArgs e)
        {
            FridgeSoftware.Help.Show(2);
            Help help = new Help();
            help.Show();
        }
    }
}

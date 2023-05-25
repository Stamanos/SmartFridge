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
    public partial class Chart : Form
    {
        TableLayoutPanel currentDataView;

        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            CreateTableView(FridgeSoftware.Shop.products.Count, FridgeSoftware.Shop.products);
            lbl_Chart.Text = FridgeSoftware.Shop.products.Sum(x => x.Value).ToString();
        }

        private void CreateBasicTableView(TableLayoutPanel shoppingPanel)
        {
            shoppingPanel.BackColor = Color.AliceBlue;
            shoppingPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            shoppingPanel.ColumnCount = 2;
            shoppingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            shoppingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            shoppingPanel.Location = new Point(3, 3);
            shoppingPanel.Name = "shoppingPanel";
            shoppingPanel.RowCount = 1;
            shoppingPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            shoppingPanel.TabIndex = 0;
            shoppingPanel.Dock = DockStyle.Top;
            shoppingPanel.Click += new EventHandler(shoppingPanel_click);
        }

        private void shoppingPanel_click(object sender, EventArgs e)
        {
            TableLayoutPanel tlp = (TableLayoutPanel)sender;
            int row = FridgeSoftware.GetRowIndex(tlp.Height, tlp.GetRowHeights(), tlp.PointToClient(Cursor.Position));
            string key = FridgeSoftware.Shop.products.Keys.ElementAt(row - 1);
            DialogResult dialogResult = MessageBox.Show(key, "Delete Selected Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int removedProducts = FridgeSoftware.Shop.products[key];
                FridgeSoftware.Shop.Erase(key);
                chart_Refresh();
                Shopping.chartProducts = Shopping.chartProducts - removedProducts;
            }
            else if (dialogResult == DialogResult.No)
            {
                //Nothing
            }
            lbl_Chart.Text = FridgeSoftware.Shop.products.Sum(x => x.Value).ToString();
        }
        private void chart_Refresh()
        {
            if (currentDataView != null)
            {
                currentDataView.DoubleClick -= shoppingPanel_click;
                pl_Shopping.Controls.Remove(currentDataView);
                currentDataView.Dispose();
            }
            CreateTableView(FridgeSoftware.Shop.products.Count, FridgeSoftware.Shop.products);
        }

        public void CreateTableView(int numbOfRows, Dictionary<string, int> dictData)
        {
            TableLayoutPanel shoppingPanel = new TableLayoutPanel();
            CreateBasicTableView(shoppingPanel);

            shoppingPanel.RowCount = numbOfRows;
            shoppingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            shoppingPanel.Controls.Add(new Label() { Text = "Product" }, 0, 0);
            shoppingPanel.Controls.Add(new Label() { Text = "Quantity" }, 1, 0);
            int row = 1;
            foreach (var key in dictData.Keys)
            {
                shoppingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                shoppingPanel.Controls.Add(new Label() { Text = key }, 0, row); //ProductName
                shoppingPanel.Controls.Add(new Label() { Text = dictData[key].ToString() }, 1, row); //Quantity
                row++;
            }
            shoppingPanel.Size = new Size(504, (numbOfRows + 1) * 50);
            pl_Shopping.Controls.Add(shoppingPanel);
            currentDataView = shoppingPanel;
        }

        private void btn_cornfirmed_Click(object sender, EventArgs e)
        {
            if ((FridgeSoftware.Shop.existingProducts.Sum(x => x.Value) + FridgeSoftware.Shop.products.Sum(x => x.Value)) <= 100)
            {
                FridgeSoftware.Inside.Combine();
                FridgeSoftware.Shop.products.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Το ψυγείο σας δεν μπορεί να χωρέσει παραπάνω προϊόντα" +
                    ", πρέπει να αφαιρέσετε απο το καλάθι σας");
            }
        }
    }
}

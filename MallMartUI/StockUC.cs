using MallMartDB;
using MallMartDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MallMartUI
{
    public partial class StockUC : UserControl
    {
        public bool SortByPrice { get; set; }
        public StockUC()
        {
            SortByPrice = false; // ברירת מחדל של העמוד הוא עם מיון לפי קטגוריה
            InitializeComponent();
        }
        public StockUC(bool sortByPrice) // כשהמשתמש בוחר למיין לפי מחיר , נשתמש בקונסטקטור
        {                                // הזה, ונשלח true
            SortByPrice = sortByPrice;
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetDataGrid();

            MyResize();
        }
        void SetDataGrid()
        {
            if (SortByPrice)
            {
                dataGridView1.DataSource = DBManager.GetProductsOrderByPrice();
            }
            else
            {
                dataGridView1.DataSource = DBManager.GetProductsGroupByCategory();
            }

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].HeaderText = "In Stock";
            dataGridView1.Columns[5].HeaderText = "On Order";
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void MyResize()
        {
            if (SortByPrice) // מחליף את ה-Bold
            {                // בין ה-Labels 
                             // לפי איזה מיון יתממש בטבלה
                priceLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                categotyLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }
            else
            {
                categotyLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                priceLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }

            label2.Size = new Size(this.Size.Width * 8 / 12, label2.Size.Height);
            label2.Location = new Point(((this.Size.Width / 2) - (label2.Size.Width / 2)), this.Height / 20);

            label1.Location = new Point(((this.Size.Width / 2) -
                ((label1.Size.Width + categotyLbl.Size.Width + priceLbl.Size.Width + 20) / 2)), this.Height * 5 / 40);

            categotyLbl.Location = new Point(label1.Location.X + label1.Size.Width + 10, this.Height * 5 / 40);

            priceLbl.Location = new Point(categotyLbl.Location.X + categotyLbl.Size.Width + 10, this.Height * 5 / 40);

            dataGridView1.Size = new Size(this.Size.Width * 10 / 12, this.Size.Height * 4 / 5);
            dataGridView1.Location = new Point(this.Size.Width / 12, this.Size.Height / 5);

            backLbl.Location = new Point(50, 9);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int value;
            int.TryParse((dataGridView1[0, e.RowIndex].Value.ToString()), out value); // column 0 is id
            Product product = DBManager.GetProductById(value);

            EditProductUC editProductUC = new EditProductUC(product, SortByPrice);
            Program.form1.ReplaceUC(editProductUC);
        }
        private void Shop_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        private void categotyLbl_Click(object sender, EventArgs e)
        {
            StockUC stockUC = new StockUC();
            Program.form1.ReplaceUC(stockUC);
        }

        private void priceLbl_Click(object sender, EventArgs e)
        {
            StockUC stockUC = new StockUC(true);
            Program.form1.ReplaceUC(stockUC);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            ManagerHomepage managerHomepage = new ManagerHomepage();
            Program.form1.ReplaceUC(managerHomepage);
        }
    }
}

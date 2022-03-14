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
    public partial class EditProductUC : UserControl
    {
        public Product Product { get; set; }
        public bool  SortByPrice { get; set; } // צריך את הפרמטר הזה כדי
                                               // לחזור לרשימה המוצרים, קובע איך למיין אותם

        List<Category> categories;

        public EditProductUC(Product product, bool sortByPrice)
        {
            this.Product = product;
            this.SortByPrice = sortByPrice;
            InitializeComponent();
        }
        private void EditProductUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetComboBoxes();
            SetLabels();
            MyResize();
        }

        private void SetLabels()
        {
            nameDetailsTxtbx.Text = Product.Name;
            priceDetailsTxtbx.Text = Product.UnitPrice.ToString();
            unitsInStockDetailsLbl.Text = Product.UnitsInStock.ToString();
            untisOnOrderDetailsLbl.Text = Product.UnitsOnOrder.ToString();
            descripDetailsTxtbx.Text = Product.Description;
        }
        private void EditProductUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void SetComboBoxes()
        {
            GenericRepository<Category> categoryRepository = new GenericRepository<Category>();
            categories = categoryRepository.GetAll().ToList();

            int index = 0;
            int selectedIndex = 0;
            foreach (var category in categories)
            {
                categoryCombox.Items.Add(category);

                if (Product.Category.Id == category.Id)
                {
                    selectedIndex = index; // ...שומר את האינדקס של הקטגוריה של המוצר הנוכחי
                }
                index++;

            }

            categoryCombox.SelectedIndex = selectedIndex; // כדי להציג אותה בתור הברירת מחדל...
        }

        private void savePrdctBtn_Click(object sender, EventArgs e)
        {
            float price;
            if (float.TryParse(priceDetailsTxtbx.Text, out price))
            {
                if (price < 0)
                {
                    MessageBox.Show("Unit price cannot be below 0");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Unit price must be a number");
                return;
            }
            Product.UnitPrice = price;

            if (categoryCombox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select category");
                return;
            }
            else
            {
                Product.Category = categories[categoryCombox.SelectedIndex];
            }

            if (nameDetailsTxtbx.Text != "")
            {
                Product.Name = nameDetailsTxtbx.Text;
            }
            else
            {
                MessageBox.Show("Name field cannot be empty");
                return;
            }

            Product.Description = descripDetailsTxtbx.Text;

            DBManager.UpdatePrudct(Product);

            StockUC stockUC = new StockUC(SortByPrice);
            Program.form1.ReplaceUC(stockUC);
        }

        void MyResize()
        {
            nameLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 4 / 36);
            nameDetailsTxtbx.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 6 / 36);
            nameDetailsTxtbx.Size = new Size(this.Size.Width * 3 / 12, nameDetailsTxtbx.Size.Height);

            categoryLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 9 / 36);
            categoryCombox.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 11 / 36);
            categoryCombox.Size = new Size(this.Size.Width * 3 / 12, categoryCombox.Size.Height);

            priceLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 14 / 36);
            priceDetailsTxtbx.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 16 / 36);

            unitsInStockLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 4 / 36);
            unitsInStockDetailsLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 6 / 36);

            unitsOnOrderLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 9 / 36);
            untisOnOrderDetailsLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 11 / 36);

            descriptionLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 14 / 36);
            descripDetailsTxtbx.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 16 / 36);
            descripDetailsTxtbx.Size = new Size(this.Size.Width * 3 / 12, this.Size.Height * 7 / 36);

            savePrdctBtn.Location = new Point(this.Size.Width * 4 / 12 - (savePrdctBtn.Size.Width / 2)
                , this.Size.Height * 28 / 36);

            delPrdctBtn.Location = new Point(this.Size.Width * 7 / 12 - (delPrdctBtn.Size.Width / 2)
                , this.Size.Height * 28 / 36);

            backLbl.Location = new Point(50, 9);
        }
        private void delPrdctBtn_Click(object sender, EventArgs e)
        {
            GenericRepository<Product> productRepo = new GenericRepository<Product>();
            productRepo.Delete(Product.Id);
            productRepo.Save();

            StockUC stockUC = new StockUC(SortByPrice);
            Program.form1.ReplaceUC(stockUC);
        }

        private void priceDetailsTxtbx_Leave(object sender, EventArgs e)
        {
            float price;
            if (float.TryParse(priceDetailsTxtbx.Text, out price))
            {
                if (price < 0)
                    MessageBox.Show("Unit price cannot be below 0");
            }
            else
                MessageBox.Show("Unit price must be a number");
        }
        private void backLbl_Click(object sender, EventArgs e)
        {
            StockUC stockUC = new StockUC(SortByPrice);
            Program.form1.ReplaceUC(stockUC);
        }

        private void nameDetailsTxtbx_Leave(object sender, EventArgs e)
        {
            if (nameDetailsTxtbx.Text == "")
                MessageBox.Show("Name field cannot be empty");
        }
    }
}

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
    public partial class AddProductToCart : UserControl
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Order Cart { get; set; }
        public OrderLine Line { get; set; }
        public AddProductToCart(Customer customer, Product product, Order cart)
        {
            InitializeComponent();
            this.Customer = customer;
            this.Product = product;
            this.Cart = cart;
            this.Line = null;
        }

        private void AddProductToCart_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            textBox1.Text = $"How many \"{Product.Name}\"s would you like to buy?";
            numericUpDown1.Maximum = Convert.ToDecimal(Product.UnitsInStock);

            foreach (var line in Cart.OrderLines)
            {
                if (line.Product.Id == Product.Id)
                { // אם המוצר כבר נמצא בעגלה אני לא רוצה שתהיה אפשרות לבחור אותו שוב כי אז אפשר לעבור
                  // את הכמות שיש לי במלאי. אז אם הלקוח בחר אותו שוב, אני נותן לו אפשרות לערוך
                  // את מס' הפריטים שהוא בחר ועדיין יש את המגבלה של הכמות המקסימלית כמו שקבעתי
                    numericUpDown1.Value = line.Quantity;
                    Line = line;
                }
            }
            MyResize();
        }
        private void AddProductToCart_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void MyResize()
        {
            textBox1.Size = new Size(this.Size.Width * 7 / 12, this.Size.Height);
            textBox1.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 2 / 12);
            numericUpDown1.Location = new Point(this.Size.Width * 10 / 12, this.Size.Height * 3 / 12);
            approveBtn.Location = new Point(this.Size.Width * 4 / 12, this.Size.Height * 8 / 12);
            cancelBtn.Location = new Point(this.Size.Width * 13 / 24, this.Size.Height * 8 / 12);
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (Line == null) // המוצר הוא "חדש" בעגלה וצריך ליצור לו שורה חדשה
            {
                OrderLine orderLine = new OrderLine()
                {
                    Order = this.Cart,
                    Product = this.Product,
                    UnitPrice = this.Product.UnitPrice,
                    Quantity = Decimal.ToInt32(numericUpDown1.Value)
                };
                Cart.OrderLines.Add(orderLine);
            }
            else // המוצר כבר קיים בעגלה, יש לו שורה ורק צריך לעדכן את הכמות
            {
                Line.Quantity = Decimal.ToInt32(numericUpDown1.Value);
            }
            Parent.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Parent.Visible = false;
        }
    }
}

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
    public partial class FinishOrderUC : UserControl
    {
        public Customer Customer { get; set; }
        public Order Cart { get; set; }
        public FinishOrderUC(Customer customer, Order cart)
        {
            this.Customer = customer;
            this.Cart = cart;
            InitializeComponent();
        }

        private void FinishOrderUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetMinDate();
            SetComboBox();
            MyResize();
        }

        private void FinishOrderUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void MyResize()
        {
            label1.Location = new Point(((this.Size.Width / 2) - ((label1.Size.Width + dateTimePicker1.Size.Width) / 2))
                , this.Height / 10);
            dateTimePicker1.Location = new Point(label1.Location.X + label1.Size.Width + 10, this.Height / 10);
            comboBox1.Location = new Point(label1.Location.X + label1.Size.Width + 10, this.Height * 2 / 10);
            label2.Location = new Point(label1.Location.X, this.Height * 3 / 10);
            commentTxtbx.Location = new Point(label1.Location.X, this.Height * 7 / 20);
            confirmBtn.Location = new Point((this.Size.Width / 2) - (confirmBtn.Size.Width / 2), this.Height * 6 / 10);
        }

        void SetComboBox()
        {
            comboBox1.Items.Add("08:00-12:00");
            comboBox1.Items.Add("12:00-16:00");
            comboBox1.Items.Add("16:00-20:00");
        }

        void SetMinDate()
        {
            bool containsVideoCards = false;
            bool containsCars = false;

            foreach (var line in Cart.OrderLines)
            {
                if (line.Product.Category.Name == "Video Cards")
                {
                    containsVideoCards = true;
                }
                if (line.Product.Category.Name == "Cars")
                {
                    containsCars = true;
                }
            }
            if (containsCars)
            {
                dateTimePicker1.MinDate = DateTime.Now.AddDays(14);
            }
            else if (containsVideoCards)
            {
                dateTimePicker1.MinDate = DateTime.Now.AddDays(7);
            }
            else
            {
                dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value.Date;
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the hour you want to receive your order in");
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                 dateTime = dateTime.AddHours(8);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dateTime = dateTime.AddHours(12);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dateTime = dateTime.AddHours(16);
            }
            Cart.DateOrdered = DateTime.Now;
            Cart.DueTimeFirst = dateTime;
            Cart.DueTimeLast = dateTime.AddHours(4);
            Cart.Comment = commentTxtbx.Text;
            Cart.Customer = Customer;

            foreach (var line in Cart.OrderLines)
            {
                DBManager.UpdatePrudctQuantity(line.Product.Id, line.Quantity);
            }

            DBManager.SaveOrder(Cart);

            MessageBox.Show($"Thank you for your purchase, {Customer.User.FirstName}. Have a lovely day!");
            Shop shop = new Shop(Customer.User);
            Program.form1.ReplaceUC(shop);
        }
    }
}

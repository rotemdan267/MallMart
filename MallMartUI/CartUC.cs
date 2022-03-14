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
    public partial class CartUC : UserControl
    {
        public Customer Customer { get; set; }
        public Order Cart { get; set; }
        public CartUC(Customer customer, Order cart)
        {
            this.Customer = customer;
            this.Cart = cart;
            InitializeComponent();
        }

        private void CartUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            label2.Visible = true;

            dataGridView1.DataSource = Cart.OrderLines;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            Cart.SetTotalPrice();
            label4.Text = "For a total of:";
            label5.Text = $"{Cart.TotalPrice}$";
            checkBox1.Text = $"I agree to pay {Cart.TotalPrice}$\n" +
                             $"using my saved payment method";
            MyResize();

        }

        private void CartUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void MyResize()
        {
            label2.Size = new Size(this.Size.Width * 8 / 12, label2.Size.Height);
            label2.Location = new Point(((this.Size.Width / 2) - ((label2.Size.Width + dataGridView1.Size.Width) / 2))
                , this.Height / 10);

            label4.Location = new Point(label2.Location.X + ((label2.Size.Width / 2) - (label4.Size.Width / 2))
                , this.Height * 2 / 10);

            label5.Size = new Size(this.Size.Width * 8 / 12, label2.Size.Height);
            label5.Location = new Point(label4.Location.X + ((label4.Size.Width / 2) - (label5.Size.Width / 2))
                , this.Height * 5 / 20);

            checkBox1.Location = new Point(label2.Location.X + ((label2.Size.Width / 2) - (checkBox1.Size.Width / 2))
                , this.Height * 6 / 20);

            confirmBtn.Location = new Point(label4.Location.X + ((label4.Size.Width / 2) - (confirmBtn.Size.Width / 2))
                , this.Height * 9 / 20);

            clearLbl.Location = new Point(label4.Location.X + ((label4.Size.Width / 2) - (clearLbl.Size.Width / 2))
                , this.Height * 15 / 20);

            label1.Location = new Point(clearLbl.Location.X + clearLbl.Size.Width + 10, this.Height * 15 / 20);

            backLbl.Location = new Point(101, 9);

            dataGridView1.Size = new Size(this.Size.Width * 4 / 12, this.Size.Height * 3 / 5);
            dataGridView1.Location = new Point(checkBox1.Location.X + checkBox1.Size.Width + 10
                , this.Height / 10);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("You must agree to pay for your order");
                return;
            }

            Cart.PricePaid = Cart.TotalPrice;

            FinishOrderUC finishOrder = new FinishOrderUC(Customer, Cart);
            Program.form1.ReplaceUC(finishOrder);
        }

        private void clearLbl_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(Customer.User);
            Program.form1.ReplaceUC(shop);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(Customer.User, Cart);
            Program.form1.ReplaceUC(shop);
        }
    }
}

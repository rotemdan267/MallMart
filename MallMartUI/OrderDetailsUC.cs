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
    public partial class OrderDetailsUC : UserControl
    {
        public Order Order { get; set; }
        public Employee Employee { get; set; }

        public OrderDetailsUC(Order order, Employee employee)
        {
            Order = order;
            Employee = employee;
            InitializeComponent();
        }
        private void OrderDetailsUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetLabels();
            SetDataGrid();
            MyResize();
        }

        private void OrderDetailsUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        private void SetLabels()
        {
            fNameDetailsBtn.Text = Order.Customer.User.FirstName;
            lNameDetailsBtn.Text = Order.Customer.User.LastName;
            emailDetailsBtn.Text = Order.Customer.User.Email;
            phoneDetailsBtn.Text = Order.Customer.User.Phone;
            regionDetailsBtn.Text = Order.Customer.Address.Region.ToString();
            cityDetailsBtn.Text = Order.Customer.Address.City;
            streetDetailsBtn.Text = Order.Customer.Address.Street;
            streetNoDetailsBtn.Text = Order.Customer.Address.StreetNo.ToString();

            entraDetailsBtn.Visible = false;
            if (Order.Customer.Address.Entrance != null)
            {
                entraDetailsBtn.Text = Order.Customer.Address.Entrance.ToString();
                entraDetailsBtn.Visible = true;
            }

            apartNoDetailsBtn.Visible = false;
            if (Order.Customer.Address.ApartmentNo != null)
            {
                apartNoDetailsBtn.Text = Order.Customer.Address.ApartmentNo.ToString();
                apartNoDetailsBtn.Visible = true;
            }

            postalDetailsBtn.Visible = false;
            if (Order.Customer.Address.Postal != null)
            {
                postalDetailsBtn.Text = Order.Customer.Address.Postal.ToString();
                postalDetailsBtn.Visible = true;
            }
        }

        void SetDataGrid()
        {
            dataGridView1.DataSource = Order.OrderLines;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void orderDeliveredBtn_Click(object sender, EventArgs e)
        {
            if (!Order.IsPaid)
            {
                MessageBox.Show("The order hasn't been fully-paid yet.\n" +
                                "Please notify your superior.");
            }
            else
                Order.IsOrderDone = true;

            Order.ArrivalTime = DateTime.Now;

            GenericRepository<Product> repoProducts = new GenericRepository<Product>();
            Product product;
            foreach (var line in Order.OrderLines)
            {
                product = repoProducts.GetById(line.ProductId);
                product.UnitsOnOrder -= line.Quantity;
                repoProducts.Update(product);
                repoProducts.Save();
            }

            GenericRepository<Order> repoOrder = new GenericRepository<Order>();
            repoOrder.Update(Order);
            repoOrder.Save();

            DeliveryboyHomepageUC deliveryboyHomepageUC = new DeliveryboyHomepageUC(Employee.User);
            Program.form1.ReplaceUC(deliveryboyHomepageUC);
        }

        void MyResize()
        {
            firstNameLbl.Location = new Point(this.Size.Width / 12, this.Size.Height / 36);
            fNameDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 3 / 36);

            lastNameLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 6 / 36);
            lNameDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 8 / 36);

            emailLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 11 / 36);
            emailDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 13 / 36);

            phoneLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 16 / 36);
            phoneDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 18 / 36);

            regionLbl.Location = new Point(this.Size.Width * 3 / 12, this.Size.Height / 36);
            regionDetailsBtn.Location = new Point(this.Size.Width * 3 / 12, this.Size.Height * 3 / 36);

            cityLbl.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height / 36);
            cityDetailsBtn.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 3 / 36);

            postalLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height / 36);
            postalDetailsBtn.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 3 / 36);

            streetLbl.Location = new Point(this.Size.Width * 3 / 12, this.Size.Height * 6 / 36);
            streetDetailsBtn.Location = new Point(this.Size.Width * 3 / 12, this.Size.Height * 8 / 36);

            streetNoLbl.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 6 / 36);
            streetNoDetailsBtn.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 8 / 36);

            entranceLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 6 / 36);
            entraDetailsBtn.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 8 / 36);

            apartNoLbl.Location = new Point(this.Size.Width * 9 / 12, this.Size.Height * 6 / 36);
            apartNoDetailsBtn.Location = new Point(this.Size.Width * 9 / 12, this.Size.Height * 8 / 36);

            dataGridView1.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 13 / 36);
            dataGridView1.Size = new Size(this.Size.Width * 5 / 12, this.Size.Height * 20 / 36);

            orderDeliveredBtn.Location = new Point(this.Size.Width * 3 / 12, this.Size.Height * 22 / 36);

            backLbl.Location = new Point(50, 9);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            DeliveryboyHomepageUC deliveryboyHomepageUC = new DeliveryboyHomepageUC(Employee.User);
            Program.form1.ReplaceUC(deliveryboyHomepageUC);
        }
    }
}
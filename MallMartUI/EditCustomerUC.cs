using MallMartDB;
using MallMartDB.Models;
using MMUsersManagement;
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
    public partial class EditCustomerUC : UserControl
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
        public bool DidUserComeFromCustomersList { get; set; }
        public bool AreOrdersDelivered { get; set; }
        public EditCustomerUC(Customer customer)
        {
            Customer = customer;
            DidUserComeFromCustomersList = true;
            InitializeComponent();
        }
        public EditCustomerUC(Customer customer, Order order, bool areOrdersDelivered)
        {
            DidUserComeFromCustomersList = false; // האפשרות השניה היא להגיע מהמסך של עריכת הזמנה
            Customer = customer;
            Order = order;
            AreOrdersDelivered = areOrdersDelivered; // כשחוזרים למסך של עריכת הזמנה צריך את המשתנה הזה. עיין שם
            InitializeComponent();
        }
        void MyResize()
        {
            usernameLbl.Location = new Point(this.Size.Width / 12, this.Size.Height / 36);
            usernameDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 3 / 36);

            firstNameLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 6 / 36);
            fNameDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 8 / 36);

            lastNameLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 11 / 36);
            lNameDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 13 / 36);

            emailLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 16 / 36);
            emailDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 18 / 36);

            phoneLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 21 / 36);
            phoneDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 23 / 36);

            payMethodLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 26 / 36);
            payMethDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 28 / 36);

            payDetailsLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 31 / 36);
            payDetDetailsBtn.Location = new Point(this.Size.Width / 12, this.Size.Height * 33 / 36);

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

            ordersLbl.Location = new Point(this.Size.Width * 4 / 12, this.Size.Height * 12 / 36);

            dataGridView1.Location = new Point(this.Size.Width * 4 / 12, this.Size.Height * 14 / 36);
            dataGridView1.Size = new Size(this.Size.Width * 7 / 12, this.Size.Height * 17 / 36);

            backLbl.Location = new Point(50, 9);
        }
        private void EditCustomerUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetLabels();
            SetDataGrid();
            MyResize();
        }

        private void EditCustomerUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void SetDataGrid()
        {
            dataGridView1.DataSource = Customer.Orders;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Date Ordered";
            dataGridView1.Columns[3].HeaderText = "First time asked";
            dataGridView1.Columns[4].HeaderText = "Last time asked";
            dataGridView1.Columns[5].HeaderText = "Arrival Time";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "Total Price";
            dataGridView1.Columns[8].HeaderText = "Price Paid";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void SetLabels()
        {
            usernameDetailsBtn.Text = Customer.User.Username;
            fNameDetailsBtn.Text = Customer.User.FirstName;
            lNameDetailsBtn.Text = Customer.User.LastName;
            emailDetailsBtn.Text = Customer.User.Email;
            phoneDetailsBtn.Text = Customer.User.Phone;
            regionDetailsBtn.Text = Customer.Address.Region.ToString();
            cityDetailsBtn.Text = Customer.Address.City;
            streetDetailsBtn.Text = Customer.Address.Street;
            streetNoDetailsBtn.Text = Customer.Address.StreetNo.ToString();

            entraDetailsBtn.Visible = false;
            if (Customer.Address.Entrance != null)
            {
                entraDetailsBtn.Text = Customer.Address.Entrance.ToString();
                entraDetailsBtn.Visible = true;
            }

            apartNoDetailsBtn.Visible = false;
            if (Customer.Address.ApartmentNo != null)
            {
                apartNoDetailsBtn.Text = Customer.Address.ApartmentNo.ToString();
                apartNoDetailsBtn.Visible = true;
            }

            postalDetailsBtn.Visible = false;
            if (Customer.Address.Postal != null)
            {
                postalDetailsBtn.Text = Customer.Address.Postal.ToString();
                postalDetailsBtn.Visible = true;
            }

            payMethDetailsBtn.Text = Customer.PaymentMethod.ToString();
            payDetDetailsBtn.Text = Customer.PaymentDetails;
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            if (DidUserComeFromCustomersList)
            {
                CustomersListUC customersListUC = new CustomersListUC();
                Program.form1.ReplaceUC(customersListUC);
            }
            else
            {
                EditOrderUC editOrderUC = new EditOrderUC(Order, AreOrdersDelivered);
                Program.form1.ReplaceUC(editOrderUC);
            }
        }
    }
}

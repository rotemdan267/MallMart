using MallMartDB;
using MallMartDB.Models;
using MallMartLogic;
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
    public partial class CustomersListUC : UserControl
    {
        public CustomersListUC()
        {
            InitializeComponent();
        }

        void MyResize()
        {
            label2.Location = new Point(((this.Size.Width / 2) - (label2.Size.Width / 2)), this.Height / 20);

            dataGridView1.Size = new Size(this.Size.Width * 10 / 12, this.Size.Height * 7 / 10);
            dataGridView1.Location = new Point(this.Size.Width / 12, this.Size.Height / 5);

            backLbl.Location = new Point(50, 9);
        }
        private void CustomersListUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetDataGrid();
            MyResize();
        }
        void SetDataGrid()
        {
            var customers = DBManager.GetCustomers();
            List<CustomerWithUser> customerWithUser = new List<CustomerWithUser>();
            List<Order> orders = new List<Order>();
            foreach (var customer in customers)
            {
                foreach (var order in customer.Orders)
                {
                    Order order1 = DBManager.GetOrderById(order.OrderId); // מייבא ל"הזמנה" את כל היישויות שתחתיה
                    orders.Add(order1);
                }
                customer.Orders = orders;
                customerWithUser.Add(new CustomerWithUser(customer, customer.User));
            }

            dataGridView1.DataSource = customerWithUser;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].HeaderText = "Payment Method";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderText = "Payment Details";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].HeaderText = "First Name";
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].HeaderText = "Last Name";
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;

        }
        private void CustomersListUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }
        private void backLbl_Click(object sender, EventArgs e)
        {
            ManagerHomepage managerHomepage = new ManagerHomepage();
            Program.form1.ReplaceUC(managerHomepage);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int value;
            int.TryParse((dataGridView1[0, e.RowIndex].Value.ToString()), out value); // column 0 is id
            Customer customer = DBManager.GetCustomerById(value);

            EditCustomerUC editCustomerUC = new EditCustomerUC(customer);
            Program.form1.ReplaceUC(editCustomerUC);
        }

    }
}

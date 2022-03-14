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
    public partial class DeliveryboyHomepageUC : UserControl
    {
        public User User { get; set; }
        public Employee Employee { get; set; }
        public DeliveryboyHomepageUC(User user)
        {
            User = user;
            Employee = DBManager.GetEmployeeByUser(user);
            InitializeComponent();
        }
        private void DeliveryboyHomepageUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetDataGrid();
            MyResize();
        }

        private void DeliveryboyHomepageUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void SetDataGrid()
        {
            dataGridView1.DataSource = DBManager.GetOrdersByEmployee(Employee);
            if (dataGridView1.DataSource != null)
            {
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
        }

        void MyResize()
        {
            label2.Location = new Point(((this.Size.Width / 2) - (label2.Size.Width / 2)), this.Height / 20);

            dataGridView1.Size = new Size(this.Size.Width * 10 / 12, this.Size.Height * 7 / 10);
            dataGridView1.Location = new Point(this.Size.Width / 12, this.Size.Height / 5);
        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int value;
            int.TryParse((dataGridView1[0, e.RowIndex].Value.ToString()), out value); // column 0 is id
            Order order = DBManager.GetOrderById(value);
            OrderDetailsUC orderDetailsUC = new OrderDetailsUC(order, Employee);
            Program.form1.ReplaceUC(orderDetailsUC);
        }
    }
}

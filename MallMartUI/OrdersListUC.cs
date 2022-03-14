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
    public partial class OrdersListUC : UserControl
    {
        public bool AreOrdersDeliverd { get; set; }
        public OrdersListUC(bool areOrdersDeliverd)
        {
            InitializeComponent();
            AreOrdersDeliverd = areOrdersDeliverd;
        }
        private void OrdersListUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetDataGrid();
            MyResize();
        }

        void SetDataGrid()
        {
            dataGridView1.DataSource = DBManager.GetOrders(AreOrdersDeliverd);
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

        private void OrdersListUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void MyResize()
        {
            label2.Location = new Point(((this.Size.Width / 2) - (label2.Size.Width / 2)), this.Height / 20);

            dataGridView1.Size = new Size(this.Size.Width * 10 / 12, this.Size.Height * 4 / 5);
            dataGridView1.Location = new Point(this.Size.Width / 12, this.Size.Height / 5);

            backLbl.Location = new Point(50, 9);
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
            Order order = DBManager.GetOrderById(value);
            EditOrderUC editOrderUC = new EditOrderUC(order, AreOrdersDeliverd);
            Program.form1.ReplaceUC(editOrderUC);
        }
    }
}

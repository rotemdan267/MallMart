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
    public partial class EditOrderUC : UserControl
    {
        public Order Order { get; set; }
        public bool AreOrdersDeliverd { get; set; } // המשתנה ישמור מאיזה סוג של רשימת הזמנות הגענו למסך הזה כדי לחזור לשם

        List<Employee> employees;

        public EditOrderUC(Order order, bool areOrdersDeliverd)
        {
            Order = order;
            employees = new List<Employee>();
            InitializeComponent();
            AreOrdersDeliverd = areOrdersDeliverd;
        }

        private void EditOrderUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetComboBoxes();
            SetLabels();
            SetDataGrid();
            MyResize();
        }

        private void SetLabels()
        {
            customerDetailsBtn.Text = Order.Customer.ToString();
            dateOrderedDetailsLbl.Text = Order.DateOrdered.ToString();
            firstTimeDetailsLbl.Text = Order.DueTimeFirst.ToString();
            lastTimeDetailsLbl.Text = Order.DueTimeLast.ToString();

            if (Order.ArrivalTime != null)
                arrivalTimeDetailsLbl.Text = Order.ArrivalTime.ToString();
            else
                arrivalTimeDetailsLbl.Text = "";

            if (Order.IsOrderDone)
            {
                totalPriceDetailsTxtbx.Font = new Font("Arial", 14);
                totalPriceDetailsTxtbx.BackColor = Color.Azure;
                totalPriceDetailsTxtbx.BorderStyle = BorderStyle.None;
                totalPriceDetailsTxtbx.ReadOnly = true;
            }
            totalPriceDetailsTxtbx.Text = Order.TotalPrice.ToString();

            if (Order.PricePaid != null)
                pricePaidDetailsLbl.Text = Order.PricePaid.ToString();
            else
                pricePaidDetailsLbl.Text = "0";

            if (Order.Comment != null)
                commentDetailsTxtbx.Text = Order.Comment.ToString();
            else
            {
                commentLbl.Visible = false;
                commentDetailsTxtbx.Visible = false;
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

        private void EditOrderUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void SetComboBoxes()
        {
            isOrdDoneCombx.Items.Add("No");
            isOrdDoneCombx.Items.Add("Yes");

            switch (Order.IsOrderDone)
            {
                case false:
                    isOrdDoneCombx.SelectedIndex = 0;
                    break;

                case true:
                    isOrdDoneCombx.SelectedIndex = 1;
                    break;
            }

            employees = DBManager.GetEmployeesByRegion(Order.Customer.Address.Region.Id);
            int index = 0;
            int selectedIndex = 0;
            foreach (var employee in employees)
            {
                employeesCombox.Items.Add(employee.User.FirstName + " " + employee.User.LastName);
                if (Order.Employee is not null)
                {
                    if (Order.Employee.Id == employee.Id)
                    {
                        selectedIndex = index; // ...שומר את האינדקס של העובד הנוכחי שמטפל בהזמנה
                    }
                    index++;
                }
            }
            if (Order.Employee is not null)
                employeesCombox.SelectedIndex = selectedIndex; // כדי להציג אותו בתור הברירת מחדל...
        }

        private void saveEmpBtn_Click(object sender, EventArgs e)
        {
            float price;
            if (float.TryParse(totalPriceDetailsTxtbx.Text, out price))
                Order.TotalPrice = price;
            else
            {
                MessageBox.Show("Total price must be a number");
                return;
            }

            if (isOrdDoneCombx.SelectedIndex == 0)
            {
                Order.IsOrderDone = false;
            }
            if (isOrdDoneCombx.SelectedIndex == 1)
            {
                Order.IsOrderDone = true;
            }

            if (employeesCombox.SelectedIndex != -1)
            {
                Order.Employee = employees[employeesCombox.SelectedIndex];
                Order.EmployeeId = employees[employeesCombox.SelectedIndex].Id;
            }

            GenericRepository<Order> repoOrder = new GenericRepository<Order>();
            repoOrder.Update(Order);
            repoOrder.Save();

            OrdersListUC ordersListUC = new OrdersListUC(AreOrdersDeliverd);
            Program.form1.ReplaceUC(ordersListUC);

        }

        void MyResize()
        {
            customerLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height / 36);
            customerDetailsBtn.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 3 / 36);

            dateOrderedLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 6 / 36);
            dateOrderedDetailsLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 8 / 36);

            firstTimeLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 11 / 36);
            firstTimeDetailsLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 13 / 36);

            lastTimeAskedLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 16 / 36);
            lastTimeDetailsLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 18 / 36);

            arrivalTimeLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 21 / 36);
            arrivalTimeDetailsLbl.Location = new Point(this.Size.Width * 2 / 12, this.Size.Height * 23 / 36);

            totalPriceLbl.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height / 36);
            totalPriceDetailsTxtbx.Location = new Point(this.Size.Width * 5 / 12 + 10, this.Size.Height * 3 / 36);

            employeeLbl.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 6 / 36);
            employeesCombox.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 8 / 36);

            pricePaidLbl.Location = new Point(this.Size.Width * 8 / 12, this.Size.Height / 36);
            pricePaidDetailsLbl.Location = new Point(this.Size.Width * 8 / 12, this.Size.Height * 3 / 36);

            commentLbl.Location = new Point(this.Size.Width * 8 / 12, this.Size.Height * 6 / 36);
            commentDetailsTxtbx.Location = new Point(this.Size.Width * 8 / 12, this.Size.Height * 8 / 36);
            commentDetailsTxtbx.Size = new Size(this.Size.Width * 7 / 24, this.Size.Height * 4 / 36);

            isOrdDoneLbl.Location = new Point(this.Size.Width * 10 / 12, this.Size.Height / 36);
            isOrdDoneCombx.Location = new Point(this.Size.Width * 10 / 12, this.Size.Height * 3 / 36);

            dataGridView1.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 13 / 36);
            dataGridView1.Size = new Size(this.Size.Width * 5 / 12, this.Size.Height * 20 / 36);

            backLbl.Location = new Point(50, 9);

            saveOrdBtn.Location = new Point(this.Size.Width * 3 / 12, this.Size.Height * 28 / 36);

            delOrdBtn.Visible = false;

            if (Order.IsOrderDone)
            {
                saveOrdBtn.Location = new Point(this.Size.Width * 3 / 12, this.Size.Height * 26 / 36);

                delOrdBtn.Visible = true;
                delOrdBtn.Location = new Point(this.Size.Width * 3 / 12, this.Size.Height * 30 / 36);
            }
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            OrdersListUC ordersListUC = new OrdersListUC(AreOrdersDeliverd);
            Program.form1.ReplaceUC(ordersListUC);
        }

        private void totalPriceDetailsTxtbx_Leave(object sender, EventArgs e)
        {
            float price;
            if (!float.TryParse(totalPriceDetailsTxtbx.Text, out price))
                MessageBox.Show("Total price must be a number");
        }

        private void isOrdDoneCombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isOrdDoneCombx.SelectedIndex == 1)
            {
                if (!Order.IsPaid)
                {
                    MessageBox.Show("The order hasn't been paid yet...");
                    isOrdDoneCombx.SelectedIndex = 0;
                    return;
                }
                if (Order.ArrivalTime == null)
                {
                    MessageBox.Show("The order hasn't been delivered yet...");
                    isOrdDoneCombx.SelectedIndex = 0;
                    return;
                }
            }

            if (isOrdDoneCombx.SelectedIndex == -1)
            {
                switch (Order.IsOrderDone)
                {
                    case false:
                        isOrdDoneCombx.SelectedIndex = 0;
                        break;

                    case true:
                        isOrdDoneCombx.SelectedIndex = 1;
                        break;
                }
            }
        }

        private void customerDetailsBtn_Click(object sender, EventArgs e)
        {
            EditCustomerUC editCustomerUC = new EditCustomerUC(Order.Customer, Order, AreOrdersDeliverd);
            Program.form1.ReplaceUC(editCustomerUC);
        }

        private void delOrdBtn_Click(object sender, EventArgs e)
        {
            if (Order.IsOrderDone)
            {
                foreach (var line in Order.OrderLines)
                {
                    DBManager.DeleteOrderLine(line);
                }
                GenericRepository<Order> orderRepo = new GenericRepository<Order>();
                orderRepo.Delete(Order.OrderId);
                orderRepo.Save();

                OrdersListUC ordersListUC = new OrdersListUC(AreOrdersDeliverd);
                Program.form1.ReplaceUC(ordersListUC);
            }
            else
                MessageBox.Show("This order is not done yet");
        }
    }
}

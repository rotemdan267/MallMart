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
    public partial class ManagerHomepage : UserControl
    {
        public ManagerHomepage()
        {
            InitializeComponent();
        }

        private void ManagerHomepage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            MyResize();
        }


        private void ManagerHomepage_Resize(object sender, EventArgs e)
        {
            MyResize();
        }
        void MyResize()
        {
            #region Panels

            panel1.Size = new Size(this.Width / 3, Program.form1.Size.Height / 3);
            panel2.Size = new Size(this.Width / 3, Program.form1.Size.Height / 3);
            panel3.Size = new Size(this.Width / 3, Program.form1.Size.Height / 3);
            panel4.Size = new Size(this.Width / 3, Program.form1.Size.Height / 3);
            panel5.Size = new Size(this.Width / 3, Program.form1.Size.Height / 3);
            panel6.Size = new Size(this.Width / 3, Program.form1.Size.Height / 3);

            panel4.Location = new Point(0, this.Size.Height - (Program.form1.Size.Height * 2 / 3));
            panel1.Location = new Point(0, this.Size.Height - (Program.form1.Size.Height / 3));

            panel5.Location = new Point(this.Width / 3,
                this.Size.Height - (Program.form1.Size.Height * 2 / 3));
            panel2.Location = new Point(this.Width / 3,
                this.Size.Height - (Program.form1.Size.Height / 3));

            panel6.Location = new Point(this.Width * 2 / 3,
                this.Size.Height - (Program.form1.Size.Height * 2 / 3));
            panel3.Location = new Point(this.Width * 2 / 3,
                this.Size.Height - (Program.form1.Size.Height / 3));

            #endregion

            #region Buttons & Labels

            employeesBtn.Location = new Point(((panel1.Size.Width / 2) - (employeesBtn.Size.Width / 2))
                , panel4.Size.Height / 2);
            newEmpBtn.Location = new Point(((panel4.Size.Width / 2) - (newEmpBtn.Size.Width / 2))
                , panel4.Size.Height * 4 / 5);

            salesLbl.Location = new Point(((panel1.Size.Width / 2) - (salesLbl.Size.Width / 2))
                , ((this.Size.Height) - (panel4.Size.Height * 9 / 10)));

            ordersBtn.Location = new Point(
                (panel4.Size.Width / 2) - ((ordersBtn.Size.Width + assignLbl.Size.Width) / 2),
                ((panel4.Size.Height * 3 / 6) + (panel1.Size.Height)));

            assignLbl.Location = new Point(
                (ordersBtn.Location.X + ordersBtn.Size.Width + 10),
                ordersBtn.Location.Y + 9);

            delOrdBtn.Location = new Point(
                (panel4.Size.Width / 2) - (delOrdBtn.Size.Width / 2),
                ((panel4.Size.Height * 5 / 6) + (panel1.Size.Height)));

            stockBtn.Location = new Point(
                (this.Size.Width / 2) - ((stockBtn.Size.Width + editPrdctLbl.Size.Width + 10) / 2),
                this.Size.Height - (panel4.Size.Height * 9 / 6) - stockBtn.Size.Height);

            editPrdctLbl.Location = new Point(stockBtn.Location.X + stockBtn.Size.Width + 5
                , (this.Size.Height - panel4.Size.Height * 9 / 6) + 10 - stockBtn.Size.Height);

            newCtgryBtn.Location = new Point(
                (panel4.Size.Width / 2) - (newCtgryBtn.Size.Width / 2) + (panel4.Size.Width * 2),
                ordersBtn.Location.Y);

            editCtgryBtn.Location = new Point(
                (panel4.Size.Width / 2) - (editCtgryBtn.Size.Width / 2) + (panel4.Size.Width * 2),
                delOrdBtn.Location.Y);

            newPrdctBtn.Location = new Point(
                (panel4.Size.Width / 2) - (newPrdctBtn.Size.Width / 2) + (panel4.Size.Width * 2),
                this.Size.Height - (panel4.Size.Height * 9 / 6) - newPrdctBtn.Size.Height);

            customersBtn.Location = new Point(
                (this.Size.Width / 2) - (customersBtn.Size.Width / 2),
                this.Size.Height - panel4.Size.Height * 3 / 6 - customersBtn.Size.Height);

            #endregion
        }

        private void newEmpBtn_Click(object sender, EventArgs e)
        {
            NewEmployeeUC newEmployeeUC = new NewEmployeeUC();
            Program.form1.ReplaceUC(newEmployeeUC);
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeesListUC employeesListUC = new EmployeesListUC();
            Program.form1.ReplaceUC(employeesListUC);
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            CustomersListUC customersListUC = new CustomersListUC();
            Program.form1.ReplaceUC(customersListUC);
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            OrdersListUC ordersListUC = new OrdersListUC(false);
            Program.form1.ReplaceUC(ordersListUC);
        }

        private void delOrdBtn_Click(object sender, EventArgs e)
        {
            OrdersListUC ordersListUC = new OrdersListUC(true);
            Program.form1.ReplaceUC(ordersListUC);
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            StockUC stockUC = new StockUC();
            Program.form1.ReplaceUC(stockUC);
        }

        private void newPrdctBtn_Click(object sender, EventArgs e)
        {
            NewProductUC newProductUC = new NewProductUC();
            Program.form1.ReplaceUC(newProductUC);
        }

        private void newCtgryBtn_Click(object sender, EventArgs e)
        {
            NewCategoryUC newCategoryUC = new NewCategoryUC();
            Program.form1.ReplaceUC(newCategoryUC);
        }

        private void editCtgryBtn_Click(object sender, EventArgs e)
        {
            CategoryListUC categoryListUC = new CategoryListUC();
            Program.form1.ReplaceUC(categoryListUC);
        }
    }
}

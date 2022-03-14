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
    public partial class EmployeesListUC : UserControl
    {
        public EmployeesListUC()
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

        private void EmployeesListUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetDataGrid();
            MyResize();
        }
        void SetDataGrid()
        {
            var employees = DBManager.GetEmployees();
            List<EmployeeWithUser> employeeWithUsers = new List<EmployeeWithUser>();
            foreach (var employee in employees)
            {
                employeeWithUsers.Add(new EmployeeWithUser(employee, employee.User));
            }

            dataGridView1.DataSource = employeeWithUsers;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].HeaderText = "Job Title";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        private void EmployeesListUC_Resize(object sender, EventArgs e)
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
            Employee employee = DBManager.GetEmployeeById(value);
            EditEmployeeUC editEmployeeUC = new EditEmployeeUC(employee);
            Program.form1.ReplaceUC(editEmployeeUC);
        }
    }
}

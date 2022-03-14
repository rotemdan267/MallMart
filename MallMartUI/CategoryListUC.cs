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
    public partial class CategoryListUC : UserControl
    {
        public CategoryListUC()
        {
            InitializeComponent();
        }

        void MyResize()
        {
            label2.Location = new Point(((this.Size.Width / 2) - (label2.Size.Width / 2)), this.Height / 20);

            dataGridView1.Size = new Size(label2.Size.Width, this.Size.Height * 7 / 10);
            dataGridView1.Location = new Point((this.Size.Width / 2) - (dataGridView1.Size.Width / 2)
                , this.Size.Height / 5);

            backLbl.Location = new Point(50, 9);
        }
        private void CategoryListUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetDataGrid();
            MyResize();
        }

        private void CategoryListUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void SetDataGrid()
        {
            GenericRepository<Category> categoryRepo = new GenericRepository<Category>();
            var categories = categoryRepo.GetAll().ToList();

            dataGridView1.DataSource = categories;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

            GenericRepository<Category> categoryRepo = new GenericRepository<Category>();
            Category category = categoryRepo.GetById(value);

            EditCategoryUC editCategoryUC = new EditCategoryUC(category);
            Program.form1.ReplaceUC(editCategoryUC);
        }
    }
}

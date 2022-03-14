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
    public partial class EditCategoryUC : UserControl
    {
        public Category Category { get; set; }
        public EditCategoryUC(Category category)
        {
            Category = category;
            InitializeComponent();
        }
        private void EditCategoryUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            nameDetailsTxtbx.Text = Category.Name;
            MyResize();
        }

        private void EditCategoryUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void MyResize()
        {
            nameDetailsTxtbx.Size = new Size(this.Size.Width * 3 / 12, nameDetailsTxtbx.Size.Height);

            nameLbl.Location = new Point(
                (this.Size.Width / 2) - ((nameLbl.Size.Width + nameDetailsTxtbx.Size.Width + 10) / 2)
                , this.Size.Height * 10 / 36);
            nameDetailsTxtbx.Location = new Point(nameLbl.Location.X + nameLbl.Size.Width + 10
                , this.Size.Height * 10 / 36);

            saveCtgryBtn.Location = new Point(
                (this.Size.Width / 2) - (saveCtgryBtn.Size.Width / 2), this.Size.Height * 25 / 36);

            backLbl.Location = new Point(50, 9);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            ManagerHomepage managerHomepage = new ManagerHomepage();
            Program.form1.ReplaceUC(managerHomepage);
        }

        private void saveCtgryBtn_Click(object sender, EventArgs e)
        {
            if (nameDetailsTxtbx.Text != "")
            {
                Category.Name = nameDetailsTxtbx.Text;
            }
            else
            {
                MessageBox.Show("Name field cannot be empty");
                return;
            }

            GenericRepository<Category> categoryRepo = new GenericRepository<Category>();
            categoryRepo.Update(Category);
            categoryRepo.Save();

            ManagerHomepage managerHomepage = new ManagerHomepage();
            Program.form1.ReplaceUC(managerHomepage);
        }
    }
}

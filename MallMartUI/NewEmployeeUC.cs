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
    public partial class NewEmployeeUC : UserControl
    {
        public RegisterUser RegisterUser { get; set; }
        public User User { get; set; }
        public Employee Employee { get; set; }

        List<Employee> managers;
        public NewEmployeeUC()
        {
            RegisterUser = new RegisterUser();
            Employee = new Employee();
            Employee.DeliveryRegions = new List<EmployeeRegion>();
            InitializeComponent();

        }

        private void NewEmployeeUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SetCheckedListBox();
            SetComboBoxes();
            MyResize();
        }

        private void NewEmployeeUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void SetCheckedListBox()
        {
            GenericRepository<MallMartDB.Models.Region> repo = new GenericRepository<MallMartDB.Models.Region>();
            List<MallMartDB.Models.Region> regions = repo.GetAll().ToList();
            foreach (var region in regions)
            {
                regionsCheckedlist.Items.Add(region.ToString());
            }
        }
        void SetComboBoxes()
        {
            jobTitleCombx.Items.Add(Job.DeliveryBoy);
            jobTitleCombx.Items.Add(Job.DeliveryManager);
            jobTitleCombx.Items.Add(Job.AcquisitonManager);
            jobTitleCombx.Items.Add(Job.Manager);

            managers = DBManager.GetManagers();
            foreach (var manager in managers)
            {
                managerCombox.Items.Add(manager.User.FirstName + " " + manager.User.LastName);
            }
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            #region Job Title

            if (jobTitleCombx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select job title");
                return;
            }
            if (jobTitleCombx.SelectedIndex == 0)
            {
                RegisterUser.SetAuthorization(Authorization.DeliveryBoy);
                Employee.JobTitle = Job.DeliveryBoy;
            }
            if (jobTitleCombx.SelectedIndex == 1)
            {
                RegisterUser.SetAuthorization(Authorization.DeliveryManager);
                Employee.JobTitle = Job.DeliveryManager;
            }
            if (jobTitleCombx.SelectedIndex == 2)
            {
                RegisterUser.SetAuthorization(Authorization.AcquisitonManager);
                Employee.JobTitle = Job.AcquisitonManager;
            }
            if (jobTitleCombx.SelectedIndex == 3)
            {
                RegisterUser.SetAuthorization(Authorization.Manager);
                Employee.JobTitle = Job.Manager;
            }

            #endregion

            #region Manager

            if (jobTitleCombx.SelectedIndex != 3) // ...אם העובד החדש הוא לא מנהל
            {
                if (managerCombox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select manager");
                    return; // ...חובה לבחור עבורו מנהל...
                }
                else
                    Employee.Manager = managers[managerCombox.SelectedIndex];
            }
            else // אחרת - אפשר לבחור עבורו מנהל אבל לא חובה...
            {
                if (managerCombox.SelectedIndex != -1)
                {
                    Employee.Manager = managers[managerCombox.SelectedIndex];
                }
            }

            #endregion

            #region Regions

            if (jobTitleCombx.SelectedIndex == 0) // אם העובד הוא "שליח"
            {
                EmployeeRegion employeeRegion;
                var selectedItems = regionsCheckedlist.CheckedItems;
                if (selectedItems.Count == 0)  // חייב לבחור מחוזות בהם הוא יכול לעבוד
                {
                    MessageBox.Show("Please select where can the delivery-boy work");
                    return;
                }
                foreach (var item in selectedItems)
                {
                    employeeRegion = new EmployeeRegion();
                    MallMartDB.Models.Region region = DBManager.GetRegionByName(item.ToString());
                    employeeRegion.Region = region;
                    employeeRegion.Employee = Employee;
                    Employee.DeliveryRegions.Add(employeeRegion);
                }
            }

            #endregion

            #region User-Validations

            if (RegisterUser.NewUsername(usernameTxtbx.Text))
            {
                if (!RegisterUser.DoesUsernameAvailable(usernameTxtbx.Text))
                {
                    MessageBox.Show("This username already exists in our system. Please pick another one");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Username must be at least 2 chars\n" +
                                "Can contain english letters and numbers only\n" +
                                "Must start with an english letter");
                return;
            }
            if (!RegisterUser.NewPassword(passwordTxtbx.Text))
            {
                MessageBox.Show("Password must contain at least 6 chars");
                return;
            }
            if (!RegisterUser.NewFirstName(fNameTxtbx.Text))
            {
                MessageBox.Show("First name must be at least 2 letters\n" +
                                "Can contain english letters only\n" +
                                "Must start with a capital letter");
                return;
            }
            if (!RegisterUser.NewLastName(lNameTxtbx.Text))
            {
                MessageBox.Show("Last name must be at least 2 letters\n" +
                                "Can contain english letters only\n" +
                                "Must start with a capital letter");
                return;
            }
            if (!RegisterUser.NewEmail(emailTxtbx.Text))
            {
                MessageBox.Show("Invalid email address");
                return;
            }
            if (!RegisterUser.NewPhone(phoneTxtbx.Text))
            {
                MessageBox.Show("Invalid israeli phone number");
                return;
            }

            User = RegisterUser.SetUsername(usernameTxtbx.Text)
                         .SetPassword(passwordTxtbx.Text)
                         .SetFirstName(fNameTxtbx.Text)
                         .SetLastName(lNameTxtbx.Text)
                         .SetEmail(emailTxtbx.Text)
                         .SetPhone(phoneTxtbx.Text)
                         .CreateUser();

            #endregion

            Employee.User = User;

            GenericRepository<User> repoUser = new GenericRepository<User>();
            repoUser.Insert(User);
            repoUser.Save();

            GenericRepository<Employee> repoEmployee = new GenericRepository<Employee>();
            repoEmployee.Insert(Employee);
            repoEmployee.Save();

            GenericRepository<EmployeeRegion> repoEmployeeRegion = new GenericRepository<EmployeeRegion>();
            foreach (var item in Employee.DeliveryRegions)
            {
                repoEmployeeRegion.Insert(item);
                repoEmployeeRegion.Save();
            }

            ManagerHomepage managerHomepage = new ManagerHomepage();
            Program.form1.ReplaceUC(managerHomepage);

        }

        void MyResize()
        {
            usernameLbl.Location = new Point(this.Size.Width *2/ 12, this.Size.Height / 36);
            usernameTxtbx.Location = new Point(this.Size.Width*2 / 12, this.Size.Height * 3 / 36);
            usernameTxtbx.Size = new Size(this.Size.Width * 3 / 12, usernameTxtbx.Size.Height);

            passLbl.Location = new Point(this.Size.Width*2 / 12, this.Size.Height * 6 / 36);
            passwordTxtbx.Location = new Point(this.Size.Width*2 / 12, this.Size.Height * 8 / 36);
            passwordTxtbx.Size = new Size(this.Size.Width * 3 / 12, passwordTxtbx.Size.Height);

            firstNameLbl.Location = new Point(this.Size.Width*2 / 12, this.Size.Height * 11 / 36);
            fNameTxtbx.Location = new Point(this.Size.Width*2 / 12, this.Size.Height * 13 / 36);
            fNameTxtbx.Size = new Size(this.Size.Width * 3 / 12, fNameTxtbx.Size.Height);

            lastNameLbl.Location = new Point(this.Size.Width*2 / 12, this.Size.Height * 16 / 36);
            lNameTxtbx.Location = new Point(this.Size.Width*2 / 12, this.Size.Height * 18 / 36);
            lNameTxtbx.Size = new Size(this.Size.Width * 3 / 12, lNameTxtbx.Size.Height);

            emailLbl.Location = new Point(this.Size.Width*2/ 12, this.Size.Height * 21 / 36);
            emailTxtbx.Location = new Point(this.Size.Width*2/ 12, this.Size.Height * 23 / 36);
            emailTxtbx.Size = new Size(this.Size.Width * 3 / 12, emailTxtbx.Size.Height);

            phoneLbl.Location = new Point(this.Size.Width*2 / 12, this.Size.Height * 26 / 36);
            phoneTxtbx.Location = new Point(this.Size.Width*2 / 12, this.Size.Height * 28 / 36);
            phoneTxtbx.Size = new Size(this.Size.Width * 3 / 12, phoneTxtbx.Size.Height);

            jobTitleLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height / 36);
            jobTitleCombx.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 3 / 36);
            jobTitleCombx.Size = new Size(this.Size.Width * 3 / 12, jobTitleCombx.Size.Height);

            managerLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 6 / 36);
            managerCombox.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 8 / 36);
            managerCombox.Size = new Size(this.Size.Width * 3 / 12, managerCombox.Size.Height);

            regionsLbl.Location = new Point(this.Size.Width * 6 / 12, this.Size.Height * 11 / 36);
            regionsCheckedlist.Location = new Point(this.Size.Width * 6 / 12, this.Size.Height * 13 / 36);
            regionsCheckedlist.Size = new Size(this.Size.Width * 3 / 12, regionsCheckedlist.Size.Height);

            addEmpBtn.Location = new Point((this.Size.Width / 2) - (addEmpBtn.Size.Width / 2)
                , this.Size.Height * 28 / 36 - 13);

            backLbl.Location = new Point(50, 9);
        }

        #region User-Validations

        private void usernameTxtbx_Leave(object sender, EventArgs e)
        {
            if (RegisterUser.NewUsername(usernameTxtbx.Text))
            {
                if (!RegisterUser.DoesUsernameAvailable(usernameTxtbx.Text))
                    MessageBox.Show("This username already exists in our system. Please pick another one");
            }
            else MessageBox.Show("Username must be at least 2 chars\n" +
                                 "Can contain english letters and numbers only\n" +
                                 "Must start with an english letter");
        }

        private void passwordTxtbx_Leave(object sender, EventArgs e)
        {
            if (!RegisterUser.NewPassword(passwordTxtbx.Text))
                MessageBox.Show("Password must contain at least 6 chars");
        }

        private void fNameTxtbx_Leave(object sender, EventArgs e)
        {
            if (!RegisterUser.NewFirstName(fNameTxtbx.Text))
                MessageBox.Show("First name must be at least 2 letters\n" +
                                "Can contain english letters only\n" +
                                "Must start with a capital letter");
        }

        private void lNameTxtbx_Leave(object sender, EventArgs e)
        {
            if (!RegisterUser.NewLastName(lNameTxtbx.Text))
                MessageBox.Show("Last name must be at least 2 letters\n" +
                                "Can contain english letters only\n" +
                                "Must start with a capital letter");
        }

        private void emailTxtbx_Leave(object sender, EventArgs e)
        {
            if (!RegisterUser.NewEmail(emailTxtbx.Text))
                MessageBox.Show("Invalid email address");
        }

        private void phoneTxtbx_Leave(object sender, EventArgs e)
        {
            if (!RegisterUser.NewPhone(phoneTxtbx.Text))
                MessageBox.Show("Invalid israeli phone number");
        }

        #endregion

        private void jobTitleCombx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (jobTitleCombx.SelectedIndex == 0)
            {
                regionsCheckedlist.Visible = true;
                regionsLbl.Visible = true;
            }
            else
            {
                regionsCheckedlist.Visible = false;
                regionsLbl.Visible = false;
            }
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            ManagerHomepage managerHomepage = new ManagerHomepage();
            Program.form1.ReplaceUC(managerHomepage);
        }
    }
}

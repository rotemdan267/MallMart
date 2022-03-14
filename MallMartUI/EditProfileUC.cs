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
    public partial class EditProfileUC : UserControl
    {
        RegisterUser RegisterUser { get; set; }
        public Customer Customer { get; set; }

        List<MallMartDB.Models.Region> regions;
        public EditProfileUC(Customer customer)
        {
            Customer = customer;
            RegisterUser = new RegisterUser();
            InitializeComponent();
        }
        void MyResize()
        {
            usernameLbl.Location = new Point(this.Size.Width / 12, this.Size.Height / 36);
            usernameTxtbx.Location = new Point(this.Size.Width / 12, this.Size.Height * 3 / 36);
            usernameTxtbx.Size = new Size(this.Size.Width * 3 / 12, usernameTxtbx.Size.Height);

            passLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 6 / 36);
            passwordTxtbx.Location = new Point(this.Size.Width / 12, this.Size.Height * 8 / 36);
            passwordTxtbx.Size = new Size(this.Size.Width * 3 / 12, passwordTxtbx.Size.Height);

            firstNameLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 11 / 36);
            fNameTxtbx.Location = new Point(this.Size.Width / 12, this.Size.Height * 13 / 36);
            fNameTxtbx.Size = new Size(this.Size.Width * 3 / 12, fNameTxtbx.Size.Height);

            lastNameLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 16 / 36);
            lNameTxtbx.Location = new Point(this.Size.Width / 12, this.Size.Height * 18 / 36);
            lNameTxtbx.Size = new Size(this.Size.Width * 3 / 12, lNameTxtbx.Size.Height);

            emailLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 21 / 36);
            emailTxtbx.Location = new Point(this.Size.Width / 12, this.Size.Height * 23 / 36);
            emailTxtbx.Size = new Size(this.Size.Width * 3 / 12, emailTxtbx.Size.Height);

            phoneLbl.Location = new Point(this.Size.Width / 12, this.Size.Height * 26 / 36);
            phoneTxtbx.Location = new Point(this.Size.Width / 12, this.Size.Height * 28 / 36);
            phoneTxtbx.Size = new Size(this.Size.Width * 3 / 12, phoneTxtbx.Size.Height);

            regionLbl.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height / 36);
            regionCombx.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 3 / 36);
            regionCombx.Size = new Size(this.Size.Width * 2 / 12, regionCombx.Size.Height);

            cityLbl.Location = new Point(this.Size.Width * 8 / 12, this.Size.Height / 36);
            cityTxtbx.Location = new Point(this.Size.Width * 8 / 12, this.Size.Height * 3 / 36);
            cityTxtbx.Size = new Size(this.Size.Width * 3 / 12, cityTxtbx.Size.Height);

            streetLbl.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 6 / 36);
            streetTxtbx.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 8 / 36);
            streetTxtbx.Size = new Size(this.Size.Width * 3 / 12, streetTxtbx.Size.Height);

            streetNoLbl.Location = new Point(this.Size.Width * 9 / 12, this.Size.Height * 6 / 36);
            streetNumTxtbx.Location = new Point(this.Size.Width * 9 / 12, this.Size.Height * 8 / 36);
            streetNumTxtbx.Size = new Size(this.Size.Width / 12, streetNumTxtbx.Size.Height);

            entranceLbl.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 11 / 36);
            entranceTxtbx.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 13 / 36);
            entranceTxtbx.Size = new Size(this.Size.Width / 12, entranceTxtbx.Size.Height);

            apartNoLbl.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 11 / 36);
            apartNoTxtbx.Location = new Point(this.Size.Width * 7 / 12, this.Size.Height * 13 / 36);
            apartNoTxtbx.Size = new Size(this.Size.Width / 12, apartNoTxtbx.Size.Height);

            postalLbl.Location = new Point(this.Size.Width * 9 / 12, this.Size.Height * 11 / 36);
            postalTxtbx.Location = new Point(this.Size.Width * 9 / 12, this.Size.Height * 13 / 36);
            postalTxtbx.Size = new Size(this.Size.Width * 2 / 12, postalTxtbx.Size.Height);

            payMethodLbl.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 16 / 36);
            payMethCombx.Location = new Point(this.Size.Width * 5 / 12, this.Size.Height * 18 / 36);
            payMethCombx.Size = new Size(this.Size.Width * 2 / 12, payMethCombx.Size.Height);

            payDetailsLbl.Location = new Point(this.Size.Width * 8 / 12, this.Size.Height * 16 / 36);
            payDetailsTxtbx.Location = new Point(this.Size.Width * 8 / 12, this.Size.Height * 18 / 36);
            payDetailsTxtbx.Size = new Size(this.Size.Width * 3 / 12, payDetailsTxtbx.Size.Height);

            saveBtn.Location = new Point(this.Size.Width * 6 / 12, this.Size.Height * 28 / 36 - 13);
            saveBtn.Size = new Size(this.Size.Width * 2 / 12, saveBtn.Size.Height);

            backLbl.Location = new Point(50, 9);
        }

        private void EditProfileUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            SetComboBoxes();
            SetLabels();
            MyResize();
        }

        void SetLabels()
        {
            usernameTxtbx.Text = Customer.User.Username;
            passwordTxtbx.Text = Customer.User.Password;
            fNameTxtbx.Text = Customer.User.FirstName;
            lNameTxtbx.Text = Customer.User.LastName;
            emailTxtbx.Text = Customer.User.Email;
            phoneTxtbx.Text = Customer.User.Phone;

            payDetailsTxtbx.Text = Customer.PaymentDetails;

            cityTxtbx.Text = Customer.Address.City;
            streetTxtbx.Text = Customer.Address.Street;
            streetNumTxtbx.Text = Customer.Address.StreetNo.ToString();
            entranceTxtbx.Text = Customer.Address.Entrance.ToString();
            apartNoTxtbx.Text = Customer.Address.ApartmentNo.ToString();
            postalTxtbx.Text = Customer.Address.Postal.ToString();
        }

        private void EditProfileUC_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void SetComboBoxes()
        {
            GenericRepository<MallMartDB.Models.Region> repo = new GenericRepository<MallMartDB.Models.Region>();
            regions = repo.GetAll().ToList();

            int index = 0;
            int selectedIndex = 0;
            foreach (var region in regions)
            {
                regionCombx.Items.Add(region.ToString());
                if (region.Id == Customer.Address.Region.Id)
                {
                    selectedIndex = index;
                }
                index++;
            }
            if (regionCombx.Items.Count > 0)
            {
                regionCombx.SelectedIndex = selectedIndex;
            }

            payMethCombx.Items.Add(PaymentMethod.Visa);
            payMethCombx.Items.Add(PaymentMethod.Mastercard);
            payMethCombx.Items.Add(PaymentMethod.Paypal);
            payMethCombx.Items.Add(PaymentMethod.Bitcoin);

            switch (Customer.PaymentMethod)
            {
                case PaymentMethod.Visa:
                    payMethCombx.SelectedIndex = 0;
                    break;

                case PaymentMethod.Mastercard:
                    payMethCombx.SelectedIndex = 1;
                    break;

                case PaymentMethod.Paypal:
                    payMethCombx.SelectedIndex = 2;
                    break;

                case PaymentMethod.Bitcoin:
                    payMethCombx.SelectedIndex = 3;
                    break;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (regionCombx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the region you live in");
                return;
            }
            else
            {
                Customer.Address.Region = regions[regionCombx.SelectedIndex];
            }

            if (payMethCombx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select you payment method");
                return;
            }
            if (payMethCombx.SelectedIndex == 0)
            {
                Customer.PaymentMethod = PaymentMethod.Visa;
            }
            if (payMethCombx.SelectedIndex == 1)
            {
                Customer.PaymentMethod = PaymentMethod.Mastercard;
            }
            if (payMethCombx.SelectedIndex == 2)
            {
                Customer.PaymentMethod = PaymentMethod.Paypal;
            }
            if (payMethCombx.SelectedIndex == 3)
            {
                Customer.PaymentMethod = PaymentMethod.Bitcoin;
            }

            #region User-Validations

            if (RegisterUser.NewUsername(usernameTxtbx.Text))
            {
                if (!RegisterUser.DoesUsernameAvailable(usernameTxtbx.Text, Customer.User))
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

            Customer.User.Username = usernameTxtbx.Text;
            Customer.User.Password = passwordTxtbx.Text;
            Customer.User.FirstName = fNameTxtbx.Text;
            Customer.User.LastName = lNameTxtbx.Text;
            Customer.User.Email = emailTxtbx.Text;
            Customer.User.Phone = phoneTxtbx.Text;

            #endregion

            bool isAddressValid = IsAddressValid();

            if (!isAddressValid)
                return;

            if (payDetailsTxtbx.Text == "")
            {
                MessageBox.Show("Please insert payment details");
                return;
            }

            Customer.PaymentDetails = payDetailsTxtbx.Text;

            var userRepo = new GenericRepository<User>();
            userRepo.Update(Customer.User);
            userRepo.Save();

            DBManager.UpdateAddress(Customer.Address);

            var customerRepo = new GenericRepository<Customer>();
            customerRepo.Update(Customer);
            customerRepo.Save();

            Shop shop = new Shop(Customer.User);
            Program.form1.ReplaceUC(shop);
        }

        bool IsAddressValid()
        {
            if (!Customer.Address.SetCity(cityTxtbx.Text))
            {
                MessageBox.Show("City must be at least 2 letters\n" +
                                "Can contain english letters only\n" +
                                "Must start with a capital letter");
                return false;
            }

            if (!Customer.Address.SetStreet(streetTxtbx.Text))
            {
                MessageBox.Show("Street must be at least 2 letters\n" +
                                "Can contain english letters only\n" +
                                "Must start with a capital letter");
                return false;
            }

            int streetNum = ValidateStreetNum(streetNumTxtbx.Text);
            if (!Customer.Address.SetStreetNo(streetNum))
            {
                MessageBox.Show("Street number must be an integer between 1-999");
                return false;
            }

            if (entranceTxtbx.Text != "") // שדה אופציונלי. נעשה וולידציה רק אם המשתמש הזין מידע
            {
                if (entranceTxtbx.Text.Length == 1)
                {
                    if (!Customer.Address.SetEntrance(entranceTxtbx.Text[0]))
                    {
                        MessageBox.Show("Entrance must be 1 capitol english letter");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Entrance must be 1 capitol english letter");
                    return false;
                }
            }
            if (apartNoTxtbx.Text != "") // שדה אופציונלי. נעשה וולידציה רק אם המשתמש הזין מידע
            {
                int apartNum = ValidateApartNum(apartNoTxtbx.Text);
                if (!Customer.Address.SetApartmentNo(apartNum))
                {
                    MessageBox.Show("Apartment number must be an integer between 1-999");
                    return false;
                }
            }
            if (postalTxtbx.Text != "") // שדה אופציונלי. נעשה וולידציה רק אם המשתמש הזין מידע
            {
                int postal = ValidatePostalNum(postalTxtbx.Text);
                if (!Customer.Address.SetPostal(postal))
                {
                    MessageBox.Show("Postal must be a 5-digit or a 7-digit integer");
                    return false;
                }
            }

            return true;
        }

        #region Validations

        #region User-Validations

        private void usernameTxtbx_Leave(object sender, EventArgs e)
        {
            if (RegisterUser.NewUsername(usernameTxtbx.Text))
            {
                if (!RegisterUser.DoesUsernameAvailable(usernameTxtbx.Text, Customer.User))
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

        #region Address-Validation

        private void cityTxtbx_Leave(object sender, EventArgs e)
        {
            if (!Customer.Address.SetCity(cityTxtbx.Text))
                MessageBox.Show("City must be at least 2 letters\n" +
                                "Can contain english letters only\n" +
                                "Must start with a capital letter");
        }

        private void streetTxtbx_Leave(object sender, EventArgs e)
        {
            if (!Customer.Address.SetStreet(streetTxtbx.Text))
                MessageBox.Show("Street must be at least 2 letters\n" +
                                "Can contain english letters only\n" +
                                "Must start with a capital letter");
        }

        private void streetNumTxtbx_Leave(object sender, EventArgs e)
        {
            int streetNum = ValidateStreetNum(streetNumTxtbx.Text);
            if (!Customer.Address.SetStreetNo(streetNum))
                MessageBox.Show("Street number must be an integer between 1-999");
        }
        int ValidateStreetNum(string streetNum)
        {
            int num;
            bool validate = int.TryParse(streetNum, out num);
            if (validate)
            {
                return num;
            }
            else
            {
                return -1; // -1
                           // יכשל ב:
                           //Address.SetStreetNo()
            }
        }

        private void entranceTxtbx_Leave(object sender, EventArgs e)
        {
            if (entranceTxtbx.Text != "") // שדה אופציונלי. נעשה וולידציה רק אם המשתמש הזין מידע
            {
                if (entranceTxtbx.Text.Length == 1)
                {
                    if (!Customer.Address.SetEntrance(entranceTxtbx.Text[0]))
                        MessageBox.Show("Entrance must be 1 capitol english letter");
                }
                else MessageBox.Show("Entrance must be 1 capitol english letter");
            }
        }

        private void apartNoTxtbx_Leave(object sender, EventArgs e)
        {
            if (apartNoTxtbx.Text != "") // שדה אופציונלי. נעשה וולידציה רק אם המשתמש הזין מידע
            {
                int apartNum = ValidateApartNum(apartNoTxtbx.Text);
                if (!Customer.Address.SetApartmentNo(apartNum))
                    MessageBox.Show("Apartment number must be an integer between 1-999");
            }
        }
        int ValidateApartNum(string apartNum)
        {
            int num;
            bool validate = int.TryParse(apartNum, out num);
            if (validate)
            {
                return num;
            }
            else
            {
                return -1; // -1
                           // יכשל ב:
                           //Address.SetApartmentNo()
            }
        }

        private void postalTxtbx_Leave(object sender, EventArgs e)
        {
            if (postalTxtbx.Text != "") // שדה אופציונלי. נעשה וולידציה רק אם המשתמש הזין מידע
            {
                int postal = ValidatePostalNum(postalTxtbx.Text);
                if (!Customer.Address.SetPostal(postal))
                    MessageBox.Show("Postal must be a 5-digit or a 7-digit integer");
            }
        }
        int ValidatePostalNum(string postal)
        {
            int num;
            bool validate = int.TryParse(postal, out num);
            if (validate)
            {
                return num;
            }
            else
            {
                return -1; // -1
                           // יכשל ב:
                           //Address.SetPostal()
            }
        }

        #endregion

        private void payDetailsTxtbx_Leave(object sender, EventArgs e)
        {
            if (payDetailsTxtbx.Text == "")
                MessageBox.Show("Please insert payment details");
        }

        #endregion

        private void backLbl_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(Customer.User);
            Program.form1.ReplaceUC(shop);
        }
    }
}
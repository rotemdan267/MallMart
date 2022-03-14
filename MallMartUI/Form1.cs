using MallMartDB;
using MallMartDB.Models;
using MMUsersManagement;

namespace MallMartUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ReplaceUC(UserControl userControl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            LoginResult loginResult = LoginResult.WrongUsername;
            User user = login.LoginMethod(usernameTxtbx.Text, passwordTxtbx.Text, ref loginResult);

            switch (loginResult)
            {
                case LoginResult.Success:
                    switch (user.Authorization)
                    {
                        case Authorization.Customer:
                            Shop shop = new Shop(user);
                            ReplaceUC(shop);
                            break;

                        case Authorization.Manager:
                            ManagerHomepage manager = new ManagerHomepage();
                            ReplaceUC(manager);
                            break;

                        case Authorization.DeliveryBoy:
                            DeliveryboyHomepageUC deliveryboyHomepageUC = new DeliveryboyHomepageUC(user);
                            ReplaceUC(deliveryboyHomepageUC);
                            break;

                        default:
                            MessageBox.Show("You do not have access yet. The page is under construction...");
                            break;

                    }
                    break;

                case LoginResult.WrongPassword:
                    MessageBox.Show("Wrong password");
                    break;

                case LoginResult.WrongUsername:
                    MessageBox.Show("Wrong username");
                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MyResize();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        void MyResize()
        {
            pictureBox1.Size = new Size(this.Width, this.Height / 4);
            panel1.Size = new Size(this.Width, this.Height * 3 / 4);
            panel1.Location = new Point(0, this.Height / 4);
            label1.Location = new Point(((this.Size.Width / 2) - (label1.Size.Width / 2)), panel1.Height / 20);
            label2.Location = new Point((this.Size.Width / 2) - (label2.Size.Width / 2), (panel1.Height / 20) * 5);
            label3.Location = new Point(label2.Location.X + (this.Size.Width / 18), (panel1.Height / 20) * 18);
            logLbl.Location = new Point(((this.Size.Width / 2) - ((logLbl.Size.Width + usernameTxtbx.Size.Width) / 2))
                , (panel1.Height / 20) * 7);
            usernameTxtbx.Location = new Point(logLbl.Location.X + 75, (panel1.Height / 20) * 7);
            passwordTxtbx.Location = new Point(logLbl.Location.X + 75, Convert.ToInt32(((panel1.Height / 20) * 8.25)));
            loginBtn.Location = new Point(((this.Size.Width / 2) - (loginBtn.Size.Width / 2)), (panel1.Height / 20) * 10);
            newLbl.Location = new Point(((this.Size.Width / 2) - ((newLbl.Size.Width + registerLbl.Size.Width) / 2)),
                (panel1.Height / 20) * 13);
            registerLbl.Location = new Point(newLbl.Location.X + 90, (panel1.Height / 20) * 13);
        }

        private void registerLbl_Click(object sender, EventArgs e)
        {
            RegisterUC registerUC = new RegisterUC();
            ReplaceUC(registerUC);
        }
    }
}
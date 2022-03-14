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
    public partial class Shop : UserControl
    {
        public User User { get; set; }
        public Customer Customer { get; set; }
        public Order Cart { get; set; }
        public bool SortByPrice { get; set; }
        public Shop(User user)
        {
            User = user;
            Customer = DBManager.GetCustomerByUser(user);
            Cart = new Order();
            Cart.OrderLines = new List<OrderLine>();
            SortByPrice = false; // ברירת מחדל של העמוד הוא עם מיון לפי קטגוריה
            InitializeComponent();
        }
        public Shop(User user, Order cart)
        {
            User = user;
            Customer = DBManager.GetCustomerByUser(user);
            Cart = cart;
            SortByPrice = false; // ברירת מחדל של העמוד הוא עם מיון לפי קטגוריה
            InitializeComponent();
        }
        public Shop(User user, Order cart, bool sortByPrice) // כשהמשתמש בוחר למיין לפי מחיר , נשתמש בקונסטקטור
        {                                                    // הזה, ונשלח true
            User = user;
            Customer = DBManager.GetCustomerByUser(user);
            Cart = cart;
            SortByPrice = sortByPrice;
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;  // נשתמש לאורך הדרך בסוג
                                         // Dock
                                         // הזה, כדי שכשמשתנה הגודל של העמוד, ישתנה גם הגודל של ה
                                         // UserControl
                                         // ויופעל אירוע 
                                         // Resize

            this.label2.Text = $"Hello {User.FirstName}. You can add a product to your cart by double-clicking on it.";

            Cart.Customer = new Customer()
            {
                User = new User()
            };

            SetDataGrid();

            MyResize();
        }
        void SetDataGrid()
        {
            if (SortByPrice)
            {
                dataGridView1.DataSource = DBManager.GetProductsOrderByPrice();
            }
            else
            {
                dataGridView1.DataSource = DBManager.GetProductsGroupByCategory();
            }

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void MyResize()  // מסדרת את כל האלמנטים על המסך כל אחד במקומו
        {
            if (SortByPrice) // מחליף את ה-Bold
            {                // בין ה-Labels 
                             // לפי איזה מיון יתממש בטבלה
                priceLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                categotyLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }
            else
            {
                categotyLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                priceLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }

            label2.Size = new Size(this.Size.Width * 8 / 12, label2.Size.Height);
            label2.Location = new Point(((this.Size.Width / 2) - (label2.Size.Width / 2)), this.Height / 20);

            label1.Location = new Point(((this.Size.Width / 2) -
                ((label1.Size.Width + categotyLbl.Size.Width + priceLbl.Size.Width + 20) / 2)), this.Height * 5 / 40);

            categotyLbl.Location = new Point(label1.Location.X + label1.Size.Width + 10, this.Height * 5 / 40);

            priceLbl.Location = new Point(categotyLbl.Location.X + categotyLbl.Size.Width + 10, this.Height * 5 / 40);

            dataGridView1.Size = new Size(this.Size.Width * 10 / 12, this.Size.Height * 4 / 5);
            dataGridView1.Location = new Point(this.Size.Width / 12, this.Size.Height / 5);

            panel1.Size = new Size(this.Size.Width / 2, this.Size.Height / 2);
            panel1.Location = new Point(this.Size.Width * 11 / 24, this.Size.Height * 5 / 12);

            cartLbl.Location = new Point(this.Size.Width - 50 - cartLbl.Size.Width, 9);

            editProfile.Location = new Point(50, 9);

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int value;
            int.TryParse((dataGridView1[0, e.RowIndex].Value.ToString()), out value); // column 0 is id
            Product product = DBManager.GetProductById(value);
            if (product.UnitsInStock > 0)
            {

                AddProductToCart addProduct = new AddProductToCart(Customer, product, Cart);
                panel1.Controls.Clear();
                panel1.Controls.Add(addProduct);
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show($"{product.Name} is currently out of stock...");
            }
        }
        private void Shop_Resize(object sender, EventArgs e)
        {
            MyResize();
        }

        private void cartLbl_Click(object sender, EventArgs e)
        {
            if (Cart.OrderLines.Count > 0)
            {
                CartUC cartUC = new CartUC(Customer, Cart);
                Program.form1.ReplaceUC(cartUC);
            }
            else
            {
                MessageBox.Show("Your Cart is empty... Add some products");
            }
        }

        private void categotyLbl_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(this.User, this.Cart);
            Program.form1.ReplaceUC(shop);
        }

        private void priceLbl_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(this.User, this.Cart, true);
            Program.form1.ReplaceUC(shop);
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            if (Customer == null)
                return;

            EditProfileUC editProfileUC = new EditProfileUC(Customer);
            Program.form1.ReplaceUC(editProfileUC);
        }
    }
}

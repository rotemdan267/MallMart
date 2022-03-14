using MallMartDB.Models;
using Microsoft.EntityFrameworkCore;

namespace MMDBManagement
{
    public static class DBManager
    {
        #region Select full Table

        public static List<Product> GetProductsOrderByPrice()
        {
            List<Product> products;
            using (var db = new MallMartContext())
            {
                products = db.Products.Include(p => p.Category).OrderBy(p => p.UnitPrice).ToList();
            }
            return products;
        }

        public static List<Product> GetProductsGroupByCategory()
        {
            List<Product> productsList = new List<Product>();
            using (var db = new MallMartContext())
            {
                List<Product> products = db.Products.Include(p => p.Category).ToList();
                var products1 = from product in products
                               group product by product.Category.Id;

                foreach (var group in products1)
                {
                    foreach (var product in group)
                    {
                        productsList.Add(product);
                    }
                }
            }
            return productsList;
        }

        #endregion



        #region Select Queries

        public static Product GetProductById(int id)
        {
            Product product;
            using (var db = new MallMartContext())
            {
                product = db.Products.Where(p => p.Id == id).Include(p => p.Category).FirstOrDefault();
            }
            return product;
        }

        public static Customer GetCustomerByUser(User user)
        {
            Customer customer = new Customer();
            using (var db = new MallMartContext())
            {
                customer = db.Customers.Where(c => c.User.Id == user.Id)
                    .Include(c => c.User)
                    .Include(c => c.Orders)
                    .ThenInclude(o => o.OrderLines)
                    .ThenInclude(l => l.Product)
                    .FirstOrDefault();
            }
            return customer;
        }

        public static Employee GetEmployeeByUser(User user)
        {
            Employee employee = new Employee();
            using (var db = new MallMartContext())
            {
                employee = db.Employees.Where(e => e.User.Id == user.Id).FirstOrDefault();
            }
            return employee;
        }

        #endregion

        #region Update DB Methods

        public static void UpdatePrudctQuantity(int id, int onOrder)
        {
            using (var db = new MallMartContext())
            {
                Product product = db.Products.Where(p => p.Id == id).FirstOrDefault();
                product.UnitsOnOrder += onOrder;
                product.UnitsInStock -= onOrder;
                db.SaveChanges();
            }
        }

        #endregion

        #region Add DB Methods

        public static void SaveOrder(Order order)
        {
            using (var db = new MallMartContext())
            {
                // כשאני מגיע עם
                // Order
                // שמכיל בתוכו
                // Customer
                // אפילו ששלפתי את ה"לקוח" הזה מתוך הדאטא-בייס בשלב מוקדם יותר בקוד, כשאני מבצע
                // SaveChanges
                // הוא מנסה להכניס את ה"לקוח" לדאטא-בייס ונוצרת שגיאה...
                // כשאני שולף את הלקוח פה - זה עובד. כנ"ל לגבי "מוצר" בשורת הזמנה

                order.Customer = db.Customers.Where(c => c.CustomerId == order.Customer.CustomerId).FirstOrDefault();
                foreach (var line in order.OrderLines)
                {
                    line.Product = db.Products.Where(p => p.Id == line.Product.Id).FirstOrDefault();
                }
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        #endregion
    }
}
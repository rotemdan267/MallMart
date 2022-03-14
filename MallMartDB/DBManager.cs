using MallMartDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMartDB
{
    // קלאס עבור שאר ה-
    // Queries
    // ופעולות ב-DB
    // שלא כלולים ב-GenericRepository
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

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees;
            using (var db = new MallMartContext())
            {
                employees = db.Employees.Include(p => p.User).ToList();
            }
            return employees;
        }

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers;
            using (var db = new MallMartContext())
            {
                customers = db.Customers
                    .Include(p => p.User)
                    .Include(c => c.Address)
                    .Include(c => c.Orders)
                    .ToList();
            }
            return customers;
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
                    .Include(c => c.Address)
                    .ThenInclude(a => a.Region)
                    .Include(c => c.Orders)
                    .ThenInclude(o => o.OrderLines)
                    .ThenInclude(l => l.Product)
                    .FirstOrDefault();
            }
            return customer;
        }

        public static Customer GetCustomerById(int id)
        {
            Customer customer = new Customer();
            using (var db = new MallMartContext())
            {
                customer = db.Customers.Where(c => c.CustomerId == id)
                    .Include(c => c.User)
                    .Include(c => c.Address)
                    .ThenInclude(a => a.Region)
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
                employee = db.Employees.Where(e => e.User.Id == user.Id)
                    .Include(e => e.User)
                    .Include(e => e.Manager)
                    .Include(e => e.Employees)
                    .Include(e => e.DeliveryRegions)
                    .ThenInclude(d => d.Region)
                    .FirstOrDefault();
            }
            return employee;
        }
        /// <summary>
        /// הייתי צריך לקבל את ה"עובד" יחד עם הישויות שמתחתיו, לכן בניתי פונקציה נוספת מלבד הג'נריק ריפו
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();
            using (var db = new MallMartContext())
            {
                employee = db.Employees.Where(e => e.Id == id)
                    .Include(e => e.User)
                    .Include(e => e.Manager)
                    .Include(e => e.Employees)
                    .Include(e => e.DeliveryRegions)
                    .ThenInclude(d => d.Region)
                    .FirstOrDefault();
            }
            return employee;
        }
        public static Order GetOrderById(int id)
        {
            Order order = new Order();
            using (var db = new MallMartContext())
            {
                order = db.Orders.Where(o => o.OrderId == id)
                    .Include(o => o.OrderLines)
                    .ThenInclude(l => l.Product)
                    .Include(o => o.Employee)
                    .ThenInclude(o => o.User)
                    .Include(o => o.Employee)
                    .ThenInclude(o => o.DeliveryRegions)
                    .Include(e => e.Customer)
                    .ThenInclude(c => c.User)
                    .Include(e => e.Customer)
                    .ThenInclude(c => c.Orders)
                    .Include(e => e.Customer)
                    .ThenInclude(c => c.Address)
                    .ThenInclude(c => c.Region)
                    .FirstOrDefault();
            }
            return order;
        }

        public static List<Employee> GetManagers()
        {
            List<Employee> managers = new List<Employee>();
            using (var db = new MallMartContext())
            {
                managers = db.Employees
                    .Where(e => e.User.Authorization == Authorization.Manager || e.User.Authorization == Authorization.DeliveryManager)
                    .Include(e => e.User).ToList();
            }
            return managers;
        }

        public static Models.Region GetRegionByName(string name)
        {
            var region = new Models.Region();
            using (var db = new MallMartContext())
            {
                region = db.Regions.Where(r => r.Name == name).FirstOrDefault();
            }
            return region;
        }

        public static List<EmployeeRegion> GetEmployeeRegionByEmployee(Employee employee)
        {
            var employeeRegions = new List<EmployeeRegion>();
            using (var db = new MallMartContext())
            {
                employeeRegions = db.EmployeeRegions.Where(r => r.Employee == employee).ToList();
            }
            return employeeRegions;
        }

        public static List<Order> GetOrders(bool areOrdersDeliverd)
        {
            var orders = new List<Order>();
            using (var db = new MallMartContext())
            {
                orders = db.Orders.Where(o => o.IsOrderDone == areOrdersDeliverd)
                    .Include(o => o.Customer)
                    .ThenInclude(c => c.User)
                    .Include(o => o.Customer)
                    .ThenInclude(c => c.Orders)
                    .Include(o => o.Customer)
                    .ThenInclude(c => c.Address)
                    .ThenInclude(a => a.Region)
                    .Include(o => o.Employee)
                    .ThenInclude(e => e.User)
                    .Include(o => o.OrderLines)
                    .ThenInclude(l => l.Product)
                    .ToList();
            }
            return orders;
        }

        public static List<Order> GetOrdersByEmployee(Employee employee)
        {
            var orders = new List<Order>();
            using (var db = new MallMartContext())
            {
                try
                {
                    orders = db.Orders
                        .Where(o => o.EmployeeId == employee.Id && o.ArrivalTime == null)
                        .Include(o => o.Customer)
                        .ThenInclude(c => c.User)
                        .Include(o => o.Customer)
                        .ThenInclude(c => c.Orders)
                        .Include(o => o.Customer)
                        .ThenInclude(c => c.Address)
                        .ThenInclude(a => a.Region)
                        .Include(o => o.Employee)
                        .ThenInclude(e => e.User)
                        .Include(o => o.OrderLines)
                        .ThenInclude(l => l.Product)
                        .ToList();
                }
                catch
                {
                    orders = null;
                }
            }
            return orders;
        }

        public static List<Employee> GetEmployeesByRegion(int regionId)
        {
            var employees = new List<Employee>();
            var employeeRegions = new List<EmployeeRegion>();
            using (var db = new MallMartContext())
            {
                employeeRegions = db.EmployeeRegions.Where((e) => e.RegionId == regionId)
                    .Include(e => e.Employee)
                    .ThenInclude(c => c.User)
                    .ToList();
            }
            foreach (var item in employeeRegions)
            {
                employees.Add(item.Employee);
            }
            return employees;
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

        public static void UpdatePrudct(Product product)
        {
            using (var db = new MallMartContext())
            {
                db.Update(product);
                db.SaveChanges();
            }
        }

        public static void UpdateAddress(Address address)
        {
            using (var db = new MallMartContext())
            {
                db.Addresses.Update(address);
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

        #region Delete DB Methods

        public static void DeleteEmployeeRegion(EmployeeRegion employeeRegion)
        { // בריפוזיטורי הסטטי מתודת "מחיקה" מקבלת 
          // id
          // אחד, ולטבלה הזו יש שניים...
          // לכן בניתי לה בנפרד
            using (var db = new MallMartContext())
            {
                db.Entry(employeeRegion).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public static void DeleteOrderLine(OrderLine orderLine)
        { // בריפוזיטורי הסטטי מתודת "מחיקה" מקבלת 
          // id
          // אחד, ולטבלה הזו יש שניים...
          // לכן בניתי לה בנפרד
            using (var db = new MallMartContext())
            {
                db.Entry(orderLine).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        #endregion
    }
}

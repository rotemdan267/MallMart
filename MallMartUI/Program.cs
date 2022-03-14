using MallMartDB;
using MallMartDB.Models;
using System.Diagnostics;

namespace MallMartUI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string fullPath = AppDomain.CurrentDomain.BaseDirectory + "MallMart-logos_transparent.png";
            FillDataBase();
            form1.pictureBox1.ImageLocation = fullPath;
            Application.Run(form1);
        }

        public static Form1 form1 = new Form1();

        #region FillDataBase Methods
        static void FillDataBase()
        {
            using (var db = new MallMartContext())
            {
                // הפונקציה הזו אמורה לעבוד רק פעם אחת, כשאין נתונים בכלל במסד הנתונים
                // לכן הוספתי תנאי כלשהו למנוע ממנה לפעול לאחר שכבר עשתה את הפעולה פעם אחת
                if (db.Regions.Count() > 0)
                    return;
            }
            //FillDataBaseCategories();
            FillDataBaseProducts();
            FillDataBaseRegions();
            FillDataBaseAddresses();
            FillDataBaseUsers();
            FillDataBaseCustomers();
            FillDataBaseEmployeesAndEmployeeRegions();
            //FillDataBaseSuppliers();
            //FillDataBaseAcquisitionOrders();
            FillDataBaseOrders();
        }
        static void FillDataBaseCategories()
        {
            using (var db = new MallMartContext())
            {
                #region Categories

                Category category;

                category = new Category()
                {
                    Name = "Snacks"
                };
                db.Categories.Add(category);

                category = new Category()
                {
                    Name = "Frozen vegetables"
                };
                db.Categories.Add(category);

                category = new Category()
                {
                    Name = "Tin cans"
                };
                db.Categories.Add(category);

                category = new Category()
                {
                    Name = "Video Cards"
                };
                db.Categories.Add(category);

                category = new Category()
                {
                    Name = "Cars"
                };
                db.Categories.Add(category);

                category = new Category()
                {
                    Name = "Sweets"
                };
                db.Categories.Add(category);

                category = new Category()
                {
                    Name = "Other"
                };
                db.Categories.Add(category);

                db.SaveChanges();


                #endregion
            }
        }
        static void FillDataBaseProducts()
        {
            using (var db = new MallMartContext())
            {
                #region Products

                Product product;

                #region Snacks

                product = new Product()
                {
                    Name = "Bamba",
                    Category = db.Categories.Where(c => c.Name == "Snacks").FirstOrDefault(),
                    UnitPrice = 3.5f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Peanuts snack"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Bissli Gril",
                    Category = db.Categories.Where(c => c.Name == "Snacks").FirstOrDefault(),
                    UnitPrice = 3.9f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Wheat snack. Gril flavoured"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Bissli Pizza",
                    Category = db.Categories.Where(c => c.Name == "Snacks").FirstOrDefault(),
                    UnitPrice = 3.9f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Wheat snack. Pizza flavoured"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Cheetos",
                    Category = db.Categories.Where(c => c.Name == "Snacks").FirstOrDefault(),
                    UnitPrice = 4f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Corn puff snack"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Doritos",
                    Category = db.Categories.Where(c => c.Name == "Snacks").FirstOrDefault(),
                    UnitPrice = 4.5f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Tortilla chips snack"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Tapuchips",
                    Category = db.Categories.Where(c => c.Name == "Snacks").FirstOrDefault(),
                    UnitPrice = 4f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Potato chips snack"
                };
                db.Products.Add(product);

                #endregion

                #region Frozen-Vegetables

                product = new Product()
                {
                    Name = "Beans",
                    Category = db.Categories.Where(c => c.Name == "Frozen vegetables").FirstOrDefault(),
                    UnitPrice = 19f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Frozen cooked beans. 800 gram"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Pea",
                    Category = db.Categories.Where(c => c.Name == "Frozen vegetables").FirstOrDefault(),
                    UnitPrice = 18f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Frozen pea. 600 gram"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "French fries",
                    Category = db.Categories.Where(c => c.Name == "Frozen vegetables").FirstOrDefault(),
                    UnitPrice = 25.9f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Frozen french fries. 1.5 kilogram"
                };
                db.Products.Add(product);

                #endregion

                #region Tin-cans

                product = new Product()
                {
                    Name = "Starkist Tuna",
                    Category = db.Categories.Where(c => c.Name == "Tin cans").FirstOrDefault(),
                    UnitPrice = 8f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Oiled tuna. 160 gram"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Corn",
                    Category = db.Categories.Where(c => c.Name == "Tin cans").FirstOrDefault(),
                    UnitPrice = 5f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Sweet corn. 550 gram"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Pickles",
                    Category = db.Categories.Where(c => c.Name == "Tin cans").FirstOrDefault(),
                    UnitPrice = 7f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 5,
                    Description = "560 gram"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Olives",
                    Category = db.Categories.Where(c => c.Name == "Tin cans").FirstOrDefault(),
                    UnitPrice = 8f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "Green olives. 560 gram"
                };
                db.Products.Add(product);

                #endregion

                #region Video-cards

                product = new Product()
                {
                    Name = "Gigabyte RTX 3070 Ti",
                    Category = db.Categories.Where(c => c.Name == "Video Cards").FirstOrDefault(),
                    UnitPrice = 5550f,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Memory Size 8 GB. Memory Type GDDR6. Output: 2xHDMI ,2xDP"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "MSI Radeon RX 6600",
                    Category = db.Categories.Where(c => c.Name == "Video Cards").FirstOrDefault(),
                    UnitPrice = 2350f,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Memory Size 8 GB. Memory Type GDDR6. Output: 1xHDMI ,3xDP"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Asus TUF Gaming RTX 3080 Ti",
                    Category = db.Categories.Where(c => c.Name == "Video Cards").FirstOrDefault(),
                    UnitPrice = 8249f,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Memory Size 12 GB. Memory Type GDDR6X. Output: 2xHDMI ,3xDP"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Gigabyte RTX 3080 GAMING",
                    Category = db.Categories.Where(c => c.Name == "Video Cards").FirstOrDefault(),
                    UnitPrice = 6290f,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Memory Size 10 GB. Memory Type GDDR6X. Output: 2xHDMI ,3xDP"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Gigabyte GTX 1660 Super",
                    Category = db.Categories.Where(c => c.Name == "Video Cards").FirstOrDefault(),
                    UnitPrice = 2390f,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Memory Size 6 GB. Memory Type GDDR6. Output: 1xHDMI ,3xDP"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Gigabyte Radeon RX 6900 XT GAMING",
                    Category = db.Categories.Where(c => c.Name == "Video Cards").FirstOrDefault(),
                    UnitPrice = 6485f,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Memory Size 16 GB. Memory Type GDDR6. Output: 2xHDMI ,2xDP"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Gigabyte AORUS RTX 3070",
                    Category = db.Categories.Where(c => c.Name == "Video Cards").FirstOrDefault(),
                    UnitPrice = 4590f,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Memory Size 8 GB. Memory Type GDDR6. Output: 3xHDMI ,3xDP"
                };
                db.Products.Add(product);

                #endregion

                #region Cars

                product = new Product()
                {
                    Name = "Volkswagen Passat⁠",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 88982,
                    UnitsInStock = 5,
                    UnitsOnOrder = 1,
                    Description = "Spacious and sporty, the capable 2022 Passat features" +
                    " an array of convenience features and driver assistance technology." +
                    " The Passat Limited Edition further boasts a Hands-Free Easy Open" +
                    " trunk, heated rear outboard seats, Fender® Premium Audio System" +
                    " and more."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Volkswagen Jetta⁠⁠",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 65167,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "When it comes to style, technology and fun, there’s " +
                    "nothing else like a Jetta. We didn’t hit the brakes designing the 2022 " +
                    "Jetta because we wanted to put the joy of driving within your reach."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Volkswagen Golf GTI⁠",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 95339,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "The new Golf GTI packs more punch and sophistication " +
                    "than ever before. Delivering a huge leap forward in performance and " +
                    "technology, and pushing a more concentrated, sportier look— its zip " +
                    "can barely be contained."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Volkswagen Atlas⁠⁠",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 88982,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Wherever you’re going, whoever you’re taking along, do " +
                    "it comfortably with the 2022 Atlas."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Audi e-tron S",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 665000,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Seamlessly melding the utility of an SUV with the " +
                    "high-level performance that only an Audi can deliver, the " +
                    "Audi e-tron® S is both practical and potent."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Audi TT Coupe",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 162960,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "The TT Coupe is a quintessential Audi design icon, " +
                    "boasting a driver-focused interior with exceptional integration of " +
                    "technology and infotainment—while still delivering true sports-car " +
                    "performance."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Audi A8",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 279128,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Beyond the elegant lines of the new 2022 Audi A8, lies " +
                    "a car so advanced it doesn’t just change the game—it can transform " +
                    "the way you drive."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Audi A5 Sportback",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 141661,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Style taken to new dimensions. Design that has no " +
                    "boundaries. The Audi A5 Sportback.."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Audi Q7",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 185547,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "As the most substantial SUV in the Audi lineup, " +
                    "the Audi Q7 has ample cargo room and more-than-accommodating " +
                    "passenger capacity—proving that bigger is better."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Audi R8 Coupe",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 1528000,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "The Audi R8 performance Coupe brings the racing-inspired" +
                    " performance you seek with uncompromised styling. This is your " +
                    "opportunity to enjoy the exhilarating performance that lies within."
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Aston Martin DB11",
                    Category = db.Categories.Where(c => c.Name == "Cars").FirstOrDefault(),
                    UnitPrice = 672570,
                    UnitsInStock = 5,
                    UnitsOnOrder = 0,
                    Description = "Standard-bearer for an all-new generation of cars, " +
                    "DB11 is the most powerful and efficient ‘DB’ production model in " +
                    "Aston Martin’s history. "
                };
                db.Products.Add(product);

                #endregion

                #region Sweets

                product = new Product()
                {
                    Name = "Bazooka Joe",
                    Category = db.Categories.Where(c => c.Name == "Sweets").FirstOrDefault(),
                    UnitPrice = 4.3f,
                    UnitsInStock = 50,
                    UnitsOnOrder = 0,
                    Description = "28 gram"
                };
                db.Products.Add(product);

                #endregion

                #region Other

                product = new Product()
                {
                    Name = "Fork relic",
                    Category = db.Categories.Where(c => c.Name == "Other").FirstOrDefault(),
                    UnitPrice = 1539f,
                    UnitsInStock = 300,
                    UnitsOnOrder = 0,
                    Description = "This fork was used on the legendary movie" +
                    " \"Titanic\"'s set. Was used by Leonardo DiCaprio himself!! " +
                    "(He used plenty of forks over there...)"
                };
                db.Products.Add(product);

                product = new Product()
                {
                    Name = "Square mile on Mars",
                    Category = db.Categories.Where(c => c.Name == "Other").FirstOrDefault(),
                    UnitPrice = 500000,
                    UnitsInStock = 1000000,
                    UnitsOnOrder = 0,
                    Description = "Agricultural land. Approved to be built on by the housing " +
                    "ministry and by the regional council. Don't be like your grandpa, who " +
                    "tells you today that he could have bought lands for a few NIS, and " +
                    "today they're worth millions. Don't miss!!!"
                };
                db.Products.Add(product);

                #endregion

                db.SaveChanges();

                #endregion
            }
        }
        static void FillDataBaseRegions()
        {
            using (var db = new MallMartContext())
            {
                #region Regions

                MallMartDB.Models.Region region = new MallMartDB.Models.Region()
                {
                    Name = "North"
                };
                db.Regions.Add(region);

                region = new MallMartDB.Models.Region()
                {
                    Name = "South"
                };
                db.Regions.Add(region);

                region = new MallMartDB.Models.Region()
                {
                    Name = "Jerusalem"
                };
                db.Regions.Add(region);

                region = new MallMartDB.Models.Region()
                {
                    Name = "Tel Aviv"
                };
                db.Regions.Add(region);

                region = new MallMartDB.Models.Region()
                {
                    Name = "Sharon"
                };
                db.Regions.Add(region);

                db.SaveChanges();

                #endregion
            }
        }
        static void FillDataBaseAddresses()
        {
            using (var db = new MallMartContext())
            {
                #region Addresses

                Address address = new Address()
                {
                    Region = db.Regions.Where(r => r.Name == "South").FirstOrDefault(),
                    City = "Dimona",
                    Street = "Dogit",
                    StreetNo = 8,
                    Entrance = null,
                    ApartmentNo = 7,
                    Postal = 68249,
                };
                db.Addresses.Add(address);

                address = new Address()
                {
                    Region = db.Regions.Where(r => r.Name == "North").FirstOrDefault(),
                    City = "Haifa",
                    Street = "Hapashosh",
                    StreetNo = 3,
                    Entrance = 'A',
                    ApartmentNo = 2,
                    Postal = 32990,
                };
                db.Addresses.Add(address);

                address = new Address()
                {
                    Region = db.Regions.Where(r => r.Name == "Jerusalem").FirstOrDefault(),
                    City = "Jerusalem",
                    Street = "Pinsker",
                    StreetNo = 11,
                    Entrance = 'D',
                    ApartmentNo = 5,
                    Postal = 31158,
                };
                db.Addresses.Add(address);

                address = new Address()
                {
                    Region = db.Regions.Where(r => r.Name == "Tel Aviv").FirstOrDefault(),
                    City = "Holon",
                    Street = "Eilat",
                    StreetNo = 38,
                    Entrance = 'E',
                    ApartmentNo = 8,
                    Postal = 74628,
                };
                db.Addresses.Add(address);

                address = new Address()
                {
                    Region = db.Regions.Where(r => r.Name == "Sharon").FirstOrDefault(),
                    City = "Netanya",
                    Street = "Nili",
                    StreetNo = 21,
                    Entrance = null,
                    ApartmentNo = null,
                    Postal = null,
                };
                db.Addresses.Add(address);

                address = new Address()
                {
                    Region = db.Regions.Where(r => r.Name == "Tel Aviv").FirstOrDefault(),
                    City = "Jaffa",
                    Street = "Shaked",
                    StreetNo = 2,
                    Entrance = null,
                    ApartmentNo = 2,
                    Postal = 86122,
                };
                db.Addresses.Add(address);

                address = new Address()
                {
                    Region = db.Regions.Where(r => r.Name == "Tel Aviv").FirstOrDefault(),
                    City = "Azur",
                    Street = "Bilu",
                    StreetNo = 5,
                    Entrance = null,
                    ApartmentNo = null,
                    Postal = 22513,
                };
                db.Addresses.Add(address);

                address = new Address()
                {
                    Region = db.Regions.Where(r => r.Name == "Tel Aviv").FirstOrDefault(),
                    City = "Sheker-Colsheu",
                    Street = "Sokolov",
                    StreetNo = 0,
                    Entrance = null,
                    ApartmentNo = null,
                    Postal = 10101,
                };
                db.Addresses.Add(address);


                db.SaveChanges();

                #endregion
            }
        }
        static void FillDataBaseUsers()
        {
            using (var db = new MallMartContext())
            {
                #region Users

                User user = new User()
                {
                    FirstName = "Rotem",
                    LastName = "Dan",
                    Email = "rotemdan@gmail.com",
                    Phone = "0522785961",
                    Username = "rotemdan",
                    Password = "123456",
                    Authorization = Authorization.Manager
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Idan",
                    LastName = "Malka",
                    Email = "idanMalka@gmail.com",
                    Phone = "0548859162",
                    Username = "idanMalka",
                    Password = "654321",
                    Authorization = Authorization.AcquisitonManager
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Nofar",
                    LastName = "Gindi",
                    Email = "nofargindi@gmail.com",
                    Phone = "0534568271",
                    Username = "nofari",
                    Password = "963852",
                    Authorization = Authorization.DeliveryManager
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Maayan",
                    LastName = "Gindi",
                    Email = "maayangindi@gmail.com",
                    Phone = "0586521349",
                    Username = "Maayan",
                    Password = "741852",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Roi",
                    LastName = "Ashkenazi",
                    Email = "ashkenaziroi@gmail.com",
                    Phone = "0579485237",
                    Username = "Ashkenazi",
                    Password = "852963",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Noa",
                    LastName = "Ashkenazi",
                    Email = "ashkenaziNoa@gmail.com",
                    Phone = "0579485238",
                    Username = "Noaly",
                    Password = "852741",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Sahar",
                    LastName = "Nasi",
                    Email = "nasisahar@gmail.com",
                    Phone = "0524330188",
                    Username = "ThePresident",
                    Password = "846351",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Gal",
                    LastName = "Malka",
                    Email = "galmalka@gmail.com",
                    Phone = "0547891543",
                    Username = "GalMalka",
                    Password = "761843",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Eli",
                    LastName = "Lasri",
                    Email = "elilasri@gmail.com",
                    Phone = "0542168294",
                    Username = "elyahu",
                    Password = "789456",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Liran",
                    LastName = "Lisha",
                    Email = "lisha@gmail.com",
                    Phone = "0576421849",
                    Username = "Liran",
                    Password = "761943",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Avi",
                    LastName = "Nasi",
                    Email = "avinasi@gmail.com",
                    Phone = "0778214976",
                    Username = "AviNasi2",
                    Password = "849562",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Yosi",
                    LastName = "Mizrahi",
                    Email = "yosiMizrahi@gmail.com",
                    Phone = "035012648",
                    Username = "MizrahiYosi",
                    Password = "778822",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Avi",
                    LastName = "Levi",
                    Email = "avilevi@gmail.com",
                    Phone = "0521035084",
                    Username = "AbrahamLevi",
                    Password = "030201",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Roni",
                    LastName = "Cohen",
                    Email = "roniCohen@gmail.com",
                    Phone = "0504443197",
                    Username = "RoniC",
                    Password = "105021",
                    Authorization = Authorization.DeliveryBoy
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Dani",
                    LastName = "Shovevani",
                    Email = "danidani@gmail.com",
                    Phone = "0508789434",
                    Username = "Shovav",
                    Password = "805060",
                    Authorization = Authorization.Customer
                };
                db.Users.Add(user);

                user = new User()
                {
                    FirstName = "Mor",
                    LastName = "Biton",
                    Email = "morBiton@gmail.com",
                    Phone = "0553021684",
                    Username = "Mor123",
                    Password = "465984",
                    Authorization = Authorization.Customer
                };
                db.Users.Add(user);

                db.SaveChanges();

                #endregion
            }
        }
        static void FillDataBaseCustomers()
        {
            using (var db = new MallMartContext())
            {
                #region Customers

                Customer customer = new Customer()
                {
                    Address = db.Addresses.Where(c => c.Street == "Shaked").FirstOrDefault(),
                    User = db.Users.Where(c => c.Username == "Mor123").FirstOrDefault(),
                    PaymentMethod = PaymentMethod.Paypal,
                    PaymentDetails = "Paypal Account: morBiton@gmail.com. Password: 465984"
                };
                db.Customers.Add(customer);

                customer = new Customer()
                {
                    Address = db.Addresses.Where(c => c.Street == "Dogit").FirstOrDefault(),
                    User = db.Users.Where(c => c.Username == "Shovav").FirstOrDefault(),
                    PaymentMethod = PaymentMethod.Bitcoin,
                    PaymentDetails = "I will pay you. For real. It's Bitcoin. It works. Wait for it..."
                };
                db.Customers.Add(customer);

                db.SaveChanges();

                #endregion
            }
        }

        static void FillDataBaseEmployeesAndEmployeeRegions()
        {
            using (var db = new MallMartContext())
            {
                #region Employees & EmployeeRegions

                Employee rotem = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "rotemdan").FirstOrDefault(),
                    ManagerId = null,
                    Manager = null,
                    JobTitle = Job.Manager,
                    DeliveryRegions = null,
                    Employees = null
                };
                db.Employees.Add(rotem);

                Employee idan = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "idanMalka").FirstOrDefault(),
                    ManagerId = rotem.Id,
                    Manager = rotem,
                    JobTitle = Job.AcquisitonManager,
                    DeliveryRegions = null,
                    Employees = null
                };
                db.Employees.Add(idan);

                Employee nofar = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "nofari").FirstOrDefault(),
                    ManagerId = rotem.Id,
                    Manager = rotem,
                    JobTitle = Job.DeliveryManager,
                    DeliveryRegions = null,
                    Employees = null
                };
                db.Employees.Add(nofar);

                Employee employee;
                EmployeeRegion employeeRegion;
                MallMartDB.Models.Region north = db.Regions.Where(r => r.Name == "North").FirstOrDefault();
                MallMartDB.Models.Region south = db.Regions.Where(r => r.Name == "South").FirstOrDefault();
                MallMartDB.Models.Region jerusalem = db.Regions.Where(r => r.Name == "Jerusalem").FirstOrDefault();
                MallMartDB.Models.Region telaviv = db.Regions.Where(r => r.Name == "Tel Aviv").FirstOrDefault();
                MallMartDB.Models.Region sharon = db.Regions.Where(r => r.Name == "Sharon").FirstOrDefault();

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "Maayan").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = telaviv,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = sharon,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "Ashkenazi").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = telaviv,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = sharon,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = jerusalem,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "Noaly").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = telaviv,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = sharon,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = south,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "ThePresident").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = jerusalem,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = south,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "GalMalka").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = sharon,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = north,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "elyahu").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = south,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = jerusalem,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "Liran").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = north,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = jerusalem,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = sharon,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "AviNasi2").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = north,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = jerusalem,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = sharon,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = telaviv,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = south,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "MizrahiYosi").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = jerusalem,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "AbrahamLevi").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = jerusalem,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = north,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = sharon,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employee = new Employee()
                {
                    User = db.Users.Where(u => u.Username == "RoniC").FirstOrDefault(),
                    ManagerId = nofar.Id,
                    Manager = nofar,
                    JobTitle = Job.DeliveryBoy,
                    Employees = null
                };
                db.Employees.Add(employee);

                employeeRegion = new EmployeeRegion()
                {
                    Region = telaviv,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = south,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);

                employeeRegion = new EmployeeRegion()
                {
                    Region = sharon,
                    EmployeeId = employee.Id,
                    Employee = employee
                };
                db.EmployeeRegions.Add(employeeRegion);


                db.SaveChanges();

                #endregion
            }
        }

        static void FillDataBaseOrders()
        {
            using (var db = new MallMartContext())
            {
                #region Orders

                Order order;
                OrderLine orderLine;

                order = new Order()
                {
                    Customer = db.Customers.FirstOrDefault(),
                    DateOrdered = new DateTime(2021, 11, 17, 11, 43, 13),
                    DueTimeFirst = new DateTime(2021, 11, 19, 8, 0, 0),
                    DueTimeLast = new DateTime(2021, 11, 19, 12, 0, 0),
                    ArrivalTime = new DateTime(2021, 11, 19, 9, 51, 42),
                    Employee = db.Employees.Where(e => e.User.Username == "Maayan").FirstOrDefault(),
                    IsOrderDone = true
                };

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Bissli Pizza").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Bissli Pizza").FirstOrDefault().UnitPrice,
                    Quantity = 4
                };
                db.OrderLines.Add(orderLine);

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Cheetos").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Cheetos").FirstOrDefault().UnitPrice,
                    Quantity = 2
                };
                db.OrderLines.Add(orderLine);

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Starkist Tuna").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Starkist Tuna").FirstOrDefault().UnitPrice,
                    Quantity = 8
                };
                db.OrderLines.Add(orderLine);
                db.Orders.Add(order);

                order.SetTotalPrice();
                order.PricePaid = order.TotalPrice;

                order = new Order()
                {
                    Customer = db.Customers.FirstOrDefault(),
                    DateOrdered = new DateTime(2022, 1, 3, 16, 2, 53),
                    DueTimeFirst = new DateTime(2022, 1, 10, 12, 0, 0),
                    DueTimeLast = new DateTime(2022, 1, 10, 16, 0, 0),
                    ArrivalTime = new DateTime(2022, 1, 10, 14, 12, 20),
                    Employee = db.Employees.Where(e => e.User.Username == "RoniC").FirstOrDefault(),
                    IsOrderDone = true
                };

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Gigabyte RTX 3070 Ti").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Gigabyte RTX 3070 Ti").FirstOrDefault().UnitPrice,
                    Quantity = 1
                };
                db.OrderLines.Add(orderLine);
                db.Orders.Add(order);

                order.SetTotalPrice();
                order.PricePaid = order.TotalPrice;

                order = new Order()
                {
                    Customer = db.Customers.Where(c => c.User.Username == "Shovav").FirstOrDefault(),
                    DateOrdered = new DateTime(2022, 1, 4, 18, 21, 53),
                    DueTimeFirst = new DateTime(2022, 1, 18, 16, 0, 0),
                    DueTimeLast = new DateTime(2022, 1, 18, 20, 0, 0),
                    ArrivalTime = new DateTime(2022, 1, 18, 18, 12, 20),
                    Employee = db.Employees.Where(e => e.User.Username == "elyahu").FirstOrDefault(),
                    IsOrderDone = true,
                    Comment = "Do you also provide a way to deliver my new Aston Martin to Mars?"
                };

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Aston Martin DB11").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Aston Martin DB11").FirstOrDefault().UnitPrice,
                    Quantity = 1
                };
                db.OrderLines.Add(orderLine);

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Square mile on Mars").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Square mile on Mars").FirstOrDefault().UnitPrice,
                    Quantity = 10
                };
                db.OrderLines.Add(orderLine);

                db.Orders.Add(order);

                order.SetTotalPrice();
                order.PricePaid = order.TotalPrice;

                order = new Order()
                {
                    Customer = db.Customers.Where(c => c.User.Username == "Shovav").FirstOrDefault(),
                    DateOrdered = new DateTime(2022, 1, 5, 19, 34, 23),
                    DueTimeFirst = new DateTime(2022, 1, 7, 16, 0, 0),
                    DueTimeLast = new DateTime(2022, 1, 7, 20, 0, 0),
                    ArrivalTime = new DateTime(2022, 1, 7, 19, 43, 28),
                    Employee = db.Employees.Where(e => e.User.Username == "Noaly").FirstOrDefault(),
                    IsOrderDone = true,
                    Comment = "Did I buy 10 square miles on Mars from you " +
                    "yesterday??? I was so high... Anyway, I already took a second " +
                    "morgage on my house so... When do you think we can drive there?"
                };

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Doritos").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Doritos").FirstOrDefault().UnitPrice,
                    Quantity = 27
                };
                db.OrderLines.Add(orderLine);

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "French fries").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "French fries").FirstOrDefault().UnitPrice,
                    Quantity = 5
                };
                db.OrderLines.Add(orderLine);

                db.Orders.Add(order);

                order.SetTotalPrice();
                order.PricePaid = order.TotalPrice;

                order = new Order()
                {
                    Customer = db.Customers.Where(c => c.User.Username == "Shovav").FirstOrDefault(),
                    DateOrdered = new DateTime(2022, 1, 5, 19, 43, 43),
                    DueTimeFirst = new DateTime(2022, 1, 7, 16, 0, 0),
                    DueTimeLast = new DateTime(2022, 1, 7, 20, 0, 0),
                    ArrivalTime = new DateTime(2022, 1, 7, 19, 43, 28),
                    Employee = db.Employees.Where(e => e.User.Username == "Noaly").FirstOrDefault(),
                    IsOrderDone = true,
                    Comment = "OMG How Did I miss That?!??! I love Leo. I'm the king of the world!!!!",
                };

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Fork relic").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Fork relic").FirstOrDefault().UnitPrice,
                    Quantity = 4
                };
                db.OrderLines.Add(orderLine);
                db.Orders.Add(order);

                order.SetTotalPrice();
                order.PricePaid = order.TotalPrice;

                order = new Order()
                {
                    Customer = db.Customers.Where(c => c.User.Username == "Shovav").FirstOrDefault(),
                    DateOrdered = new DateTime(2022, 1, 5, 19, 43, 43),
                    DueTimeFirst = new DateTime(2022, 1, 7, 16, 0, 0),
                    DueTimeLast = new DateTime(2022, 1, 7, 20, 0, 0),
                    ArrivalTime = null,
                    Employee = db.Employees.Where(e => e.User.Username == "Noaly").FirstOrDefault(),
                    IsOrderDone = true,
                    Comment = "",
                };

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Pickles").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Pickles").FirstOrDefault().UnitPrice,
                    Quantity = 5
                };
                db.OrderLines.Add(orderLine);
                db.Orders.Add(order);

                order.SetTotalPrice();
                order.PricePaid = order.TotalPrice;

                order = new Order()
                {
                    Customer = db.Customers.Where(c => c.User.Username == "Shovav").FirstOrDefault(),
                    DateOrdered = new DateTime(2022, 1, 5, 19, 43, 43),
                    DueTimeFirst = new DateTime(2022, 1, 7, 16, 0, 0),
                    DueTimeLast = new DateTime(2022, 1, 7, 20, 0, 0),
                    ArrivalTime = null,
                    Employee = db.Employees.Where(e => e.User.Username == "Noaly").FirstOrDefault(),
                    IsOrderDone = true,
                    Comment = "asdsad",
                };

                orderLine = new OrderLine()
                {
                    Order = order,
                    Product = db.Products.Where(p => p.Name == "Volkswagen Passat").FirstOrDefault(),
                    UnitPrice = db.Products.Where(p => p.Name == "Volkswagen Passat⁠").FirstOrDefault().UnitPrice,
                    Quantity = 1
                };
                db.OrderLines.Add(orderLine);
                db.Orders.Add(order);

                order.SetTotalPrice();
                order.PricePaid = order.TotalPrice;

                db.SaveChanges();


                #endregion
            }
        }

        #endregion
    }
}
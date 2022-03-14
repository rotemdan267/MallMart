using MallMartDB;
using MallMartDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMartLogic
{
    /// <summary>
    /// מחלקה שתכיל את הפרטים של "לקוח" ו"משתמש" יחד. נבנתה כדי שיהיה אפשר להכניס את הנתונים ל-dataGridView
    /// </summary>
    public class CustomerWithUser : User
    {
        public int CustomerId { get; set; }
        public Address Address { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string PaymentDetails { get; set; }
        public List<Order> Orders { get; set; }

        public CustomerWithUser(Customer customer, User user)
        {
            CustomerId = customer.CustomerId;
            Address = customer.Address;
            PaymentMethod = customer.PaymentMethod;
            PaymentDetails = customer.PaymentDetails;
            Orders = customer.Orders;

            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Phone = user.Phone;
            Username = user.Username;
            Password = user.Password;
            Authorization = user.Authorization;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

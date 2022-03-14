using MallMartDB;
using MallMartDB.Models;

namespace MallMartLogic
{
    /// <summary>
    /// מחלקה שתכיל את הפרטים של "עובד" ו"משתמש" יחד. נבנתה כדי שיהיה אפשר להכניס את הנתונים ל-dataGridView
    /// </summary>
    public class EmployeeWithUser : User
    {
        public int EmployeeId { get; set; }
        public int? ManagerId { get; set; }
        public Job JobTitle { get; set; }
        public List<EmployeeRegion> DeliveryRegions { get; set; }
        public Employee Manager { get; set; }
        public List<Employee> Employees { get; set; }

        public EmployeeWithUser(Employee employee, User user)
        {
            EmployeeId = employee.Id;
            ManagerId = employee.ManagerId;
            JobTitle = employee.JobTitle;
            DeliveryRegions = employee.DeliveryRegions;
            Manager = employee.Manager;
            Employees = employee.Employees;

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
            return $"{FirstName} {LastName} - {JobTitle.ToString()}";
        }
    }
}
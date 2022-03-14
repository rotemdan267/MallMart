using MallMartDB;
using MallMartDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MMUsersManagement
{
    public class RegisterUser
    {
        private User _user = new User();

        #region Setters

        public RegisterUser SetUsername(string username)
        {
            _user.Username = username;
            return this;
        }

        public RegisterUser SetPassword(string password)
        {
            _user.Password = password;
            return this;
        }

        public RegisterUser SetFirstName(string fName)
        {
            _user.FirstName = fName;
            return this;
        }

        public RegisterUser SetLastName(string lName)
        {
            _user.LastName = lName;
            return this;
        }

        public RegisterUser SetEmail(string email)
        {
            _user.Email = email;
            return this;
        }

        public RegisterUser SetPhone(string phone)
        {
            _user.Phone = phone;
            return this;
        }
        public RegisterUser SetAuthorization(Authorization authorization)
        {
            _user.Authorization = authorization;
            return this;
        }

        #endregion

        #region Validations
        public bool DoesUsernameAvailable(string username)
        {
            GenericRepository<User> repo = new GenericRepository<User>();
            List<User> users = repo.GetAll().ToList();

            foreach (var user in users)
            {
                if (username == user.Username)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// במסך שבו עורכים פרטים של משתמש קיים, השם משתמש שלו כבר קיים
        /// במערכת. צריך לאפשר לו להישאר עם השם משתמש הנוכחי, ורק לבדוק אם מה שהוא מזין 
        /// שונה משאר השמות-משתמש במערכת שלנו
        /// 
        /// הוא ישלח את עצמו בתור
        /// currentUser
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="currentUser"></param>
        /// <returns></returns>
        public bool DoesUsernameAvailable(string username, User currentUser)
        {
            GenericRepository<User> repo = new GenericRepository<User>();
            List<User> users = repo.GetAll().ToList();

            foreach (var user in users)
            {
                if (user.Id != currentUser.Id) // ונדלג על הבדיקה כשאנחנו רצים על המשתמשים והגענו ל- currentUser 
                { 
                    if (username == user.Username) 
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool NewUsername(string username)
        {
            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]+$");
            return regex.IsMatch(username);
            /*
             * Username must be at least 2 chars
             * Can contain english letters and numbers only
             * Must start with an english letter
             */

        }

        public bool NewPassword(string password)
        {
            Regex regex = new Regex(@".{6,}");
            return regex.IsMatch(password);
            // Password must contain at least 6 chars

        }

        public bool NewFirstName(string fName)
        {
            Regex regex = new Regex(@"^[A-Z][a-zA-Z ]*[a-zA-Z]$");
            return regex.IsMatch(fName);
        }   /*
             * First name must be at least 2 letters
             * Can contain english letters only
             * Must start with a capital letter
             */

        public bool NewLastName(string lName)
        {
            Regex regex = new Regex(@"^[A-Z][a-zA-Z ]*[a-zA-Z]$");
            return regex.IsMatch(lName);
        }   /*
             * Last name must be at least 2 letters
             * Can contain english letters only
             * Must start with a capital letter
             */

        public bool NewEmail(string email)
        {
            Regex regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return regex.IsMatch(email);
        }

        public bool NewPhone(string phone)
        {
            Regex regex = new Regex(@"[0]{1}[0-9]{8,9}");
            return regex.IsMatch(phone);
        }

        #endregion

        public User CreateUser()
        {
            return _user;
        }
    }
}

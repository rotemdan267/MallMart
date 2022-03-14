using MallMartDB;
using MallMartDB.Models;


namespace MMUsersManagement
{
    public class Login : ILogin
    {
        public User LoginMethod(string username, string pass, ref LoginResult loginResult)
        {
            User user = new User();
            GenericRepository<User> repo = new GenericRepository<User>();
            List<User> users = repo.GetAll().ToList();

            foreach (var item in users)
            {
                if (username == item.Username)
                {
                    if (pass == item.Password)
                    {
                        loginResult = LoginResult.Success;
                        user = item;
                        break;
                    }
                    else
                    {
                        loginResult = LoginResult.WrongPassword;
                        break;
                    }
                }
            }
            return user;
        }
    }
}
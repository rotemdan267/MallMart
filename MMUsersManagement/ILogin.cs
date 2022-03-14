using MallMartDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMUsersManagement
{
    public interface ILogin
    {
       User LoginMethod(string username, string password, ref LoginResult loginResult);
    }
}

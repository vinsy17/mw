using MMW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMW.Core.IService
{
    public interface IUserService
    {
        User Register(User user);
        LoginStatus Login(string EmailAddress, string Password);
        List<User> AllUserLINQ();
        List<User> AllUserSQLQuery();
    }
}

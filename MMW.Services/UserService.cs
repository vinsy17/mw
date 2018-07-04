using MMW.Core.IService;
using MMW.Core.Models;
using MMW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMW.Services
{
    public class UserService:IUserService
    {
        UserRepository userRepository = new UserRepository();
        public User Register(User user)
        {
            //using (UserRepository userRepository = new UserRepository())
            //{
            return this.userRepository.Register(user);
            //}
        }

        public LoginStatus Login(string EmailAddress, string Password)
        {
            return this.userRepository.Login(EmailAddress, Password);
        }

        public List<User> AllUserLINQ()
        {
            return this.userRepository.AllUserLINQ();
        }

        public List<User> AllUserSQLQuery()
        {
            return this.userRepository.AllUserSQLQuery();
        }
    }
}

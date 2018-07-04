using MMW.Core.IRepository;
using MMW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMW.Data
{
    public class UserRepository:IUserRepository
    {
        MMW.Data.MusicWorldEntities entities = new MusicWorldEntities();

        public User Register(User user)
        {
            using (MMW.Data.MusicWorldEntities entities = new MusicWorldEntities())
            {
                mw_User dbUser = new mw_User();
                dbUser.Email_Address=user.EmailAddress;
                dbUser.Password=user.Password;
                dbUser.First_Name=user.FirstName;
                dbUser.Display_Name=user.DispalyName;
                entities.mw_User.Add(dbUser);
                entities.SaveChanges();
                user.UserId = dbUser.User_Id;
                return user;
            }
        }

        public LoginStatus Login(string EmailAddress, string Password)
        {
            LoginStatus status = LoginStatus.INVALID;
            mw_User dbUser=entities.mw_User.FirstOrDefault(x=>x.Email_Address==EmailAddress);
            if (dbUser != null && dbUser.Email_Address == EmailAddress && dbUser.Password == Password)
            {
                status = LoginStatus.SUCCESS;
            }
            return status;
        }

        public List<User> AllUserLINQ()
        {
            var list = from s in entities.mw_User
                       select new User { EmailAddress = s.Email_Address, Password = s.Password, FirstName = s.First_Name, DispalyName = s.Display_Name };

            return list.ToList();
        }

        public List<User> AllUserSQLQuery()
        {
            var list = entities.mw_User.SqlQuery("select top 10 * from dbo.mw_User").ToList();
            List<User> output= (from s in list
                       select new User { EmailAddress = s.Email_Address, Password = s.Password, FirstName = s.First_Name, DispalyName = s.Display_Name }).ToList();

            return output;
        }
    }
}

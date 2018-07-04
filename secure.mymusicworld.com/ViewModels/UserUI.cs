using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace secure.mymusicworld.com.ViewModels
{
    public class UserUI
    {
        public long UserId { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DispalyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
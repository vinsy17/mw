using MMW.Core.IService;
using secure.mymusicworld.com.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using secure.mymusicworld.com.Utilities;
using MMW.Core.Models;

namespace secure.mymusicworld.com.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()//:this(new UserRepository)
        {
        }

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }


        #region GET: /User/Login

        [HttpGet]
        public ActionResult Login()
        {
            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["EnableTestLogin"]) && Utility.IsBool(ConfigurationManager.AppSettings["EnableTestLogin"]))
            {
                LoginUI login = new LoginUI();
                login.EmailAddress = ConfigurationManager.AppSettings["TestEmailAddress"];
                login.Password = ConfigurationManager.AppSettings["TestPassword"];
                return View(login);
            }
            else
                return View();
        }

        #endregion

        #region POST: /User/Login

        [HttpPost]
        public ActionResult Login(LoginUI loginUI)
        {
            if (loginUI != null && !string.IsNullOrWhiteSpace(loginUI.EmailAddress) && !string.IsNullOrWhiteSpace(loginUI.Password))
            {
                //FormAuthentication.
            }
            else
            {
            }
            return View();
        }
        #endregion

        #region Register
        [HttpGet]
        public ActionResult Register()
        {

            return PartialView();
        }
        #endregion


    }
}

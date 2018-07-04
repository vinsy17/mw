using MMW.Core.IService;
using MMW.Core.Models;
using MMW.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace secure.mymusicworld.com.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController()//:this(new UserRepository)
        {
            this._userService = new UserService();
        }

        public HomeController(IUserService userService)
        {
            this._userService = userService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return RedirectToAction("AllUsers", "Home");//View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        #region Show All Users
        [HttpGet]
        public ActionResult AllUsers()
        {
            List<User> userList = _userService.AllUserLINQ()??new List<User>();
            return View(userList.AsEnumerable());
        }
        #endregion

    }
}

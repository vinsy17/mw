using MMW.Core.IService;
using MMW.Services;
using secure.mymusicworld.com.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace secure.mymusicworld.com.Utilities
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            IUserService _userService= new UserService();
            //ILogger logger = new DefaultLogger();
            //var controller = new HomeController(logger);
            var controller = new UserController(_userService);
            return controller;
        }
        public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(
           System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}
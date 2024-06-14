using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ProductCRUDWebApplication1.Models;

namespace ProductCRUDWebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
            }
            else
            {
                ModelState.AddModelError("", "User is not authenticated. Please enter the user id or password");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(CL_Master_User user)
        {
            using(var context = new MLPLEntities())
            {
                var isValidUser = context.CL_Master_User.Any(u => u.UserName == user.UserName && u.Password == user.Password);
                if (isValidUser)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    // Session["Username"] = user.UserName;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username and password");
                    ViewBag.ErrorMessage = "Invalid username or password";
                    return View();
                }
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
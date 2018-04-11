using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authentication.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            //var role1check = User.IsInRole("Users");
            //var role2check = User.IsInRole("PC\\NotExistingRole");

            if (User.Identity.IsAuthenticated)
            {
               //Co zrobić jesli urzytkownik zweryfikowany
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
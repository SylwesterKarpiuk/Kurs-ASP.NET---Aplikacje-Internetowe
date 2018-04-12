using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Database.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DbFirstEntities db = new DbFirstEntities();
            var q = db.Questions.ToArray();

            return View();
        }
    }
}
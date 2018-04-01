using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewBag.Message = "Witaj, świecie";
            //var vm = new SampleViewModel { Message = "Witaj, świecie" };

            List<Course> courses = new List<Course>
            {
                new Course() { Name = "Responsive Web Design", Description = "Kurs na temat technik tworzenia stron zgodnie z...", ImageUrl="http://eduweb.pl/Images/Training/medium_3dc7546f-07f9-419f-b9b1-c16a27ed5d59.png"},
                new Course() { Name = "Preprosecesory CSS", Description = "Obejrzyj...", ImageUrl="http://eduweb.pl/Images/Training/medium_9b400ab6-febe-4abd-9738-1c175f3b8802.png"},
                new Course() { Name = "WordPress", Description = "Wiele wiedzy na temat...", ImageUrl="http://eduweb.pl/Images/Training/medium_pluginy_06486687-2821-4151-9730-d6df7b9b2eef.png"}
            };

            return View(courses);
        }

        public ActionResult LayoutSample()
        {
            return View();
        }

        public ActionResult PartialViewSimple()
        {
            return View("PartialSimple");
        }
        [ChildActionOnly]
        public ActionResult GetTimePartial()
        {
            var time = DateTime.Now.ToLongTimeString();
            return PartialView("PartialTime", time);
        }

        [ChildActionOnly]
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }

        public ActionResult Helpers()
        {
            return View();
        }
    }
}
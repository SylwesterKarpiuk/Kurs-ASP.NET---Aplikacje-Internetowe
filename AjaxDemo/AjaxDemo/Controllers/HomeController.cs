using AjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string searchQuery = null)
        {
            IEnumerable<Person> personList;

            if (searchQuery !=null)
            {
                personList = Person.GetPersonList().Where(p => p.FirstName.Contains(searchQuery) || p.LastName.Contains(searchQuery) || searchQuery == p.FirstName + " " + p.LastName).ToArray();
            }
            else
            {
                personList = Person.GetPersonList().ToArray();
            }

            if (Request.IsAjaxRequest())
            {
                return PartialView("_PersonList", personList);
            }

            return View(personList);
        }

        public ActionResult PersonSuggestions(string term)
        {
            var personList = Person.GetPersonList().Where(p => p.FirstName.Contains(term) || p.LastName.Contains(term)).Take(5).Select(p => new { label = p.FirstName + " " + p.LastName });
            return Json(personList, JsonRequestBehavior.AllowGet);
        }
    }
}
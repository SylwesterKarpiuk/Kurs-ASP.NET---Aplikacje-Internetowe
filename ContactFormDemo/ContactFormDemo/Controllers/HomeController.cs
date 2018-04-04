using ContactFormDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactFormDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddQuestion(Question question)
        {
            if (question.QuestionText=="?")
            {
                ModelState.AddModelError("QuestionText", "Komunikat dodany manualnie. Nie może być samego znak zapytania...");
            }
            if (!ModelState.IsValid)
            {
                return View("Index", question);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
using Microsoft.Security.Application;
using SecurityXSS_CSRF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityXSS_CSRF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(HomeController.Questions);
        }

        private static List<Question> Questions { get; set; }

        static HomeController()
        {
            HomeController.Questions = new List<Question>();
        }

        [ValidateInput(false)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddQuestion(Question newQuestion)
        {
            newQuestion.QuestionText = Sanitizer.GetSafeHtmlFragment(newQuestion.QuestionText);

            HomeController.Questions.Add(newQuestion);
            return RedirectToAction("Index");
        }
    }
}
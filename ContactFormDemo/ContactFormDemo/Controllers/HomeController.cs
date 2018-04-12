using ContactFormDemo.DAL;
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
                QuestionContext db = new QuestionContext();
                db.Questions.Add(question);
                db.SaveChanges();

                return View("Index");
            }
        }

        public ActionResult ShowCustomerQuestions(int customerId)
        {
            QuestionContext db = new QuestionContext();
            var customer = db.Customers.Find(customerId);
            return View(customer);
        }
    }
}
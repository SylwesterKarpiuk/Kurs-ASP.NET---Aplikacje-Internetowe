using ContactFormDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactFormDemo.DAL
{
    public class QuestionsInitializer : DropCreateDatabaseAlways<QuestionContext>
    {
        protected override void Seed(QuestionContext context)
        {
            var customers = new List<Customer>
            {
                new Customer(){Email = "jan@kowalski.com", PhoneNumber="123-321-131", WebsiteUrl="www.kowalski.net"},
                new Customer(){Email = "krzysztof@kowalski.com", PhoneNumber="343-321-767", WebsiteUrl="www.krzysztof.pl"}
            };
            customers.ForEach(g => context.Customers.Add(g));
            context.SaveChanges();

            var questions = new List<Question>
            {
                new Question(){QuestionId = 1, QuestionText = "Dlaczego nie działa aplikacja?", PhonePreferred = false},
                new Question(){QuestionId = 2, QuestionText = "Ile gwiazd jest na niebie?", PhonePreferred = true},
                new Question(){QuestionId = 3, QuestionText = "Kiedy przyjdzie lato?", PhonePreferred = false},
            };
            questions.ForEach(c => context.Questions.Add(c));
            base.Seed(context);
        }
    }
}
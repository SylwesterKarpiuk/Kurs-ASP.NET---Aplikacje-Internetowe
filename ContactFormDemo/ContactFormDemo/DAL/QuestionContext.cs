using ContactFormDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ContactFormDemo.DAL
{
    public class QuestionContext : DbContext
    {
        public QuestionContext()
            : base("QuestionsConnectionString")
        {

        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
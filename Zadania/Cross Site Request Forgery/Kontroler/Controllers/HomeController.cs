using Kontroler.Dal;
using Kontroler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kontroler.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Request.Cookies["mail"]!=null)
            {
                Data d = new Data() { Email = Request.Cookies["mail"].Value };
                return View(d);
            }
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendEmail([Bind(Include ="Email,Temat,Tresc")]Data DataDetails)
        {


            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                HttpCookie htc = new HttpCookie("mail", DataDetails.Email);
                Response.SetCookie(htc);
                DataContext db = new DataContext();
                db.Dataa.Add(DataDetails);
                db.SaveChanges();
                return View("EmailConfirmation", DataDetails);
            }
             
            
            
        }

    }
}
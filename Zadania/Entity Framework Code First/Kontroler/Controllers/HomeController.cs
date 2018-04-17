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
            return View("Index");
        }
        [HttpPost]
        public ActionResult SendEmail(Data DataDetails)
        {
            if (DataDetails.Email == "")
            {
                ModelState.AddModelError("Email","Komunikat dodany manualnie, pole adresu emial nie może być puste");
            }

            if (DataDetails.Tresc == "")
            {
                ModelState.AddModelError("Tresc", "Komunikat dodany manualnie, pole treści wiadmości nie może być puste");
            }

            if (!ModelState.IsValid)
            {
                return View("Index");
            }
             return View("EmailConfirmation", DataDetails);
            
            
        }

    }
}
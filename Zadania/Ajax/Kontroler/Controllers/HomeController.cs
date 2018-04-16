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
            return View();
        }
        [HttpPost]
        public ActionResult SendEmail(Data DataDetails)
        {
           
            return View("EmailConfirmation", DataDetails);
        }
        public ActionResult AjaxSendEmail(Data DataDetails)
        {
            return Json(DataDetails);
        }

    }
}
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
        public void SendEmail(Data data)
        {
            Response.Write(string.Format("Email: {0}, Temat: {1}, Treść: {2}", data.Email, data.Email, data.Tresc));
        }

    }
}
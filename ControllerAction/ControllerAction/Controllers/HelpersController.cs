using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerAction.Models;

namespace ControllerAction.Controllers
{
    public class HelpersController : Controller
    {
        // GET: Helpers
        public ActionResult Index()
        {
            var result = new HelpersModel()
            {
                Bool = true,
                DateTime = new DateTime(2000, 01, 02),
                Decimal = 12321321.333m,
                String = "Przykład helperów w ASP.NET MVC"
            };



            return View(result);
        }

    }
    }

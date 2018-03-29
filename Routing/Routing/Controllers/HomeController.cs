using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            var r = RouteTable.Routes.GetVirtualPath(null, new RouteValueDictionary(new { controller = "Kontroler", action = "Akcja", id = "12", parametr = "Bartek" }));
            string s = r.VirtualPath;

            return s;
        }
    }
}
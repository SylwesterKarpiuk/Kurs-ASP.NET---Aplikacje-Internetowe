using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class StaticController : Controller
    {
        // GET: Static
        
        public string Index()
        {
            return "trasa domyślna bez parametrów";
        }
        [Route("onas")]
        public string About()
        {
            return "O nas";
        }
    }
}
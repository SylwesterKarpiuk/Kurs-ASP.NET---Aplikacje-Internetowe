using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    [RoutePrefix("prefiks")]
    public class StoreController : Controller
    {
        // GET: Store
        [Route("to/jest/{moja}/trasa")]
        public string Index(string moja)
        {
            return "Attribute routeng";
        }

        [Route("{param:int}")]
        public string Attr(string param)
        {
            return param;
        }
    }
}
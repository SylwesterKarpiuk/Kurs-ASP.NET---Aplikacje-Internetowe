using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Models
{
    public class ProductsController : Controller
    {
        // GET: Products
        [Route("gatunki/{gatunek}")]
        public string Index(string gatunek)
        {
            return "Akcja index kontrolera ProductsController, wybrales gatunek " + gatunek;
        }
        public string List()
        {
            return "Akcja list kontrolera ProductsController";
        }
        
    }
}
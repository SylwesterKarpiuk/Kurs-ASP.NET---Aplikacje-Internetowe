using ControllerAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerAction.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public void ParametersBinding(int p1, int p2, int p3, int p4)
        {
            Response.Write(string.Format("p1: {0}, p2: {1}, p3: {2}, p4: {3}"));
        }

        public void ParameterBindingToClass(Album a)
        {
            Response.Write(string.Format("Title: {0}, Artist: {1}, Price: {2}", a.AlbumTitle, a.Artist.Name, a.Price));
        }
    }
}
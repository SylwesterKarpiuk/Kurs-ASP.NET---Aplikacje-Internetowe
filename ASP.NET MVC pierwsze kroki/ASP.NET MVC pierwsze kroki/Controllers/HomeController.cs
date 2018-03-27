using ASP.NET_MVC_pierwsze_kroki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_pierwsze_kroki.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Album> albumy = new List<Album>
            {
                new Album {Artist = "U2", AlbumName = "The Best of"},
                new Album {Artist = "Coldplay", AlbumName = "Mylo Xyloto"}
            };
            ViewBag.Albumy = albumy;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
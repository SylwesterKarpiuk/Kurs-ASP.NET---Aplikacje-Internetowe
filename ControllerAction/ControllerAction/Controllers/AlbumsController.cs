using ControllerAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerAction.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Album newAlbum)
        {
            return Content(string.Format("Title: {0}, Artist: {1}, Price: {2}", newAlbum.AlbumTitle, newAlbum.Artist.Name, newAlbum.Price));
        }
    }
}
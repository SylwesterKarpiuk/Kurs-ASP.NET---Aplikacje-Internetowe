using Post_Redirect_Get.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Post_Redirect_Get.Controllers
{
    public class HomeController : Controller
    {
        private object staticCounterLock = new object();

        // GET: Home
        public ActionResult Index()
        {
            var model = GetCounters();
            return View(model);
        }
        [HttpPost]
        public ActionResult PassTempData(string paramtopass)
        {
            TempData["param"] = paramtopass;
            return RedirectToAction("PRGDemo");
        }

        public ActionResult PRGDemo()
        {
            ViewBag.TempParam = TempData["param"];
            return View();
        }
        public ActionResult IncrementStatic()
        {
            lock (staticCounterLock)
            {
                var counters = GetCounters();
                counters.StaticCounter++;
            }
            return RedirectToAction("Index");
        }
        private Counters GetCounters()
        {
            var counters = new Counters();
            if (HttpContext.Application["counter"] !=null)
            {
                counters.AplicationCounter = (int)HttpContext.Application["counter"];
            }
            else
            {
                counters.AplicationCounter = 0;
            }
            return counters;
        }
        private void SetCounters(Counters counter)
        {
            HttpContext.Application["counter"] = counter.AplicationCounter;
        }
        [HttpPost]
        public ActionResult IncrementApplication()
        {
            HttpContext.Application.Lock();
            var counters = GetCounters();
            counters.AplicationCounter++;
            SetCounters(counters);
            HttpContext.Application.UnLock();

            return RedirectToAction("Index");
        }
    }
}
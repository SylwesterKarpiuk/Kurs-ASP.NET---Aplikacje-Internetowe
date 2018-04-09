using DevTrends.MvcDonutCaching;
using Post_Redirect_Get.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace Post_Redirect_Get.Controllers
{
    public class HomeController : Controller
    {
        private object staticCounterLock = new object();

        [OutputCache(Duration = 5)]
        [ChildActionOnly]
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }

        // GET: Home
        //[DonutOutputCache(Duration = 5, VaryByParam ="id")]
        public ActionResult Index(int id = 1)
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

            if (Session["counter"] != null)
            {
                counters.SessionCounter = (int)Session["counter"];
            }
            else
            {
                counters.SessionCounter = 0;
            }

            if(Request.Cookies["counter"] != null)
            {
                counters.CookieCounter = int.Parse(Request.Cookies["counter"].Value);
            }
            else
            {
                counters.CookieCounter = 0;
            }
            if (HttpRuntime.Cache["counter"] != null)
            {
                counters.CacheCounter = (int)HttpRuntime.Cache["counter"];
            }
            else
            {
                counters.CacheCounter = 0;
            }
            return counters;
        }
        private void SetCounters(Counters counter)
        {
            HttpContext.Application["counter"] = counter.AplicationCounter;

            Session["counter"] = counter.SessionCounter;

            HttpCookie cookie = new HttpCookie("counter", counter.CookieCounter.ToString());
            //cookie.Expires = DateTime.Now.AddDays(-1);
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.SetCookie(cookie);

            //HttpRuntime.Cache.Remove("counter");
            HttpRuntime.Cache.Add("counter", counter.CacheCounter, null, DateTime.Now.AddSeconds(5), TimeSpan.Zero, CacheItemPriority.Default, null);
            //HttpRuntime.Cache["counter"] = counter.CacheCounter;
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

        [HttpPost]
        public ActionResult IncrementSession()
        {
            var counters = GetCounters();

            counters.SessionCounter++;

            SetCounters(counters);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult IncrementCookies()
        {
            var counters = GetCounters();
            counters.CookieCounter++;
            SetCounters(counters);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult IncrementCache()
        {
            var counters = GetCounters();
            counters.CacheCounter++;
            SetCounters(counters);

            return RedirectToAction("Index");
        }

    }
}
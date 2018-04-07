using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Post_Redirect_Get.Models
{
    public class Counters
    {
        private static int staticCounter;

        public int StaticCounter
        {
            get
            {
                return Counters.staticCounter;
            }
            set
            {
                Counters.staticCounter = value;
            }
        }
        public int AplicationCounter { get; set; }
        public int SessionCounter { get; set; }
        public int CookieCounter { get; set; }
        public int CacheCounter { get; set; }

    }
}
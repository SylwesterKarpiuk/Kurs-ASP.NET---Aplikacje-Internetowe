using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControllerAction.Models
{
    public class Album
    {
        public string AlbumTitle { get; set; }
        public decimal Price { get; set; }

        public Artist Artist { get; set; }
    }
}
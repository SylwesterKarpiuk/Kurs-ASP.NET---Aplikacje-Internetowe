using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControllerAction.Models
{
    public class HelpersModel
    {
        public string String { get; set; }
        public decimal Decimal { get; set; }
        public bool Bool { get; set; }
        [UIHint("DateTimePicker")]
        public DateTime DateTime { get; set; }
    }
}
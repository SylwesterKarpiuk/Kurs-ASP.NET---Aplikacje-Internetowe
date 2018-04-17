using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kontroler.Models
{
    public class Data
    {
        [Display(Name = "Adres email: ")]
        [EmailAddress]
        [Required(ErrorMessage ="Wprowadź adres email!!!")]
        public string Email { get; set; }
        [Display(Name = "Temat wiadomości: ")]
        public string Temat { get; set; }
        [Display(Name = "Treść wiadomości: ")]
        [Required(ErrorMessage = "Wprowadź treść wiadomości!!!")]
        [DataType(DataType.MultilineText)]
        public string Tresc { get; set; }


    }
}
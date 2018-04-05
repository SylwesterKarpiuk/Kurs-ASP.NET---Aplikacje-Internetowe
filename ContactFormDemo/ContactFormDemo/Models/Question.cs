using ContactFormDemo.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactFormDemo.Models
{
    public class Question:IValidatableObject
    {
        [ScaffoldColumn(false)]
        public int QuestionId { get; set; }
        [Display(Name = "Pytanie:")]
        [DataType(DataType.MultilineText)]
        public string QuestionText { get; set; }
        [Display(Name = "Adres email:")]
        [Required(ErrorMessage ="Musisz wprowadzić adres email")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Preferowany kontakt telefoniczny:")]
        public bool PhonePreferred { get; set; }
        [Display(Name = "Nr telefonu:")]

        [RequiredIfTrue(BooleanPropertyName ="PhonePreffered", ErrorMessage = "Skoro preferujesz kontakt telefoniczny, podaj numer telefonu")]
        [Phone]
        [RegularExpression(@"([\+}){0,1}([0-9]{2})?[\-\s]?[-]?([0-9]{3})?[\-\s]?[-]?([0-9]{3})?[\-\s]?[-]?([0-9]{3})", 
            ErrorMessage ="Numer musi być zapisany w formacie 123-123-123")]
        public string PhoneNumber { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Email.Contains("spam"))
            {
                yield return new ValidationResult("Podany e-mail nie wygląda na prawidłowy.", new string[] { "Email" });
            }
        }
    }
}
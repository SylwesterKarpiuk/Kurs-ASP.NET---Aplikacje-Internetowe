using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxDemo.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public static IEnumerable<Person> GetPersonList()
        {
            var persons = new List<Person>
            {
                new Person() { FirstName="Jan", LastName="Kowalski"},
                new Person() { FirstName="Krzysztof", LastName="Nowak"},
                new Person() { FirstName="Mariusz", LastName="Brzeczysz"},
                new Person() { FirstName="Janusz", LastName="Marecki"},
                new Person() { FirstName="Katarzyna", LastName="Złotowska"},
                new Person() { FirstName="Julian", LastName="Lubosiński"},
                new Person() { FirstName="Grzegorz", LastName="Rogowski"},
                new Person() { FirstName="Bartłomiej", LastName="Zasiński"},
                new Person() { FirstName="Jan", LastName="Deweloperski"},
                new Person() { FirstName="Michał", LastName="Kleczkowy"},
                new Person() { FirstName="Karol", LastName="Świtała"},
            };
            return persons;
            
        }
    }
}
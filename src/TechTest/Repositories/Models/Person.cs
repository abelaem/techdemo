using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechTest.Repositories.Models  
{
    public class Person 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Authorised { get; set; }

        public bool Enabled { get; set; }

        public IEnumerable<Colour> Colours { get; set; }

       
    }
}

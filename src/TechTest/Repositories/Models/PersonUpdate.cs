using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechTest.Repositories.Models 
{
    public class PersonUpdate 
    {
       

        public bool Authorised { get; set; }
        
        public bool Enabled { get; set; }

        public IEnumerable<Colour> Colours { get; set; }

       
    }
}

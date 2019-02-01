using System.ComponentModel.DataAnnotations;

namespace TechTest.Repositories.Models 
{
    public class Colour 
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

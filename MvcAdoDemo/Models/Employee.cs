using System.ComponentModel.DataAnnotations;

namespace MvcAdoDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
    }
}

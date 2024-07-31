using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

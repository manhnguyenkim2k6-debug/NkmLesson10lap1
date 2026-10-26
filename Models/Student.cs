using System.ComponentModel.DataAnnotations;

namespace NkmLesson10Lap1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Email bat buoc phai duoc nhap")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}")]
        public string? Email { get; set; }
        [StringLength(100, MinimumLength = 6)]
        [Required]
        public string? Password { get; set; }
        [Required]
        public Gender? Gender { get; set; }
        [Required]
        public Branch? Branch { get; set; }
        public bool IsRegular { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
    }
}

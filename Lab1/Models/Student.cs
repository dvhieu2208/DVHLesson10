using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 4)]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Email bắt buộc phải được nhập")]
        [RegularExpression(@"^[^@\s]+@gmail\.com$",ErrorMessage ="Email không đúng định dạng")]
        public string? Email { get; set; }
        [StringLength(100,MinimumLength =8)]
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        public Branch? Branch { get; set; }
        [Required]
        public Gender? Gender { get; set; }

        public bool IsRegular { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }
        [Range(typeof(DateTime),"1/1/1963","31/12/2005")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBorth { get; set; }
        [Range(0,10)]
        public double Diem { get; set; }

    }
}

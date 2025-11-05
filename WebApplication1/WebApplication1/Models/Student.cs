using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        public Student(int id, string name, int score)
        {
            Id = id;
            Name = name;
            Score = score;
        }
        public Student()
        {
            Id = 0;
            Name = string.Empty;
            Score = 0;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("ชื่อนักเรียน")]
        public string Name { get; set; }

        [DisplayName("คะแนนสอบ")]
        [Range(0,100)]
        public int Score { get; set; }
    }
}

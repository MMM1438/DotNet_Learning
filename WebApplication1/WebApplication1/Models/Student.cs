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

        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}

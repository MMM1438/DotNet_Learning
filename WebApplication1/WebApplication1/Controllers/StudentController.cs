using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student s1 = new Student(1,"Roger",100);
            Student s2 = new Student(2, "Max", 99);
            Student s3 = new Student(3, "Jill", 45);

            List<Student> allStudents = new List<Student>();
            allStudents.Add(s1);
            allStudents.Add(s2);
            allStudents.Add(s3);

            return View(allStudents);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Showscore(int id)
        {
            return Content($"คะแนนสอบของนักเรียน เลขที่ {id}");
        }
    }
}

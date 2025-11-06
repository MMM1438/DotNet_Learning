using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _db;
        public StudentController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable <Student> allStudents = _db.Students;
            return View(allStudents);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Students.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Showscore(int id)
        {
            return Content($"คะแนนสอบของนักเรียน เลขที่ {id}");
        }
    }
}

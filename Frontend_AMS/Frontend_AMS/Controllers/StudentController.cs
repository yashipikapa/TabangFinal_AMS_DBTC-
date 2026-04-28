using Microsoft.AspNetCore.Mvc;
using Frontend_AMS.Models;
using Frontend_AMS.Data;

namespace Frontend_AMS.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Student.ToList());
        }
        [HttpPost]
        public IActionResult Create(StudentModel student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(StudentModel student)
        {
            _context.Student.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var student = _context.Student.Find(id);
            if (student != null)
            {
                _context.Student.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}

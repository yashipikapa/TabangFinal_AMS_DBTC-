using Microsoft.AspNetCore.Mvc;
using Frontend_AMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Frontend_AMS.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            var courses = new List<SelectListItem>
            {
                new SelectListItem { Value = "BSIT", Text = "BSIT" },
                new SelectListItem { Value = "BSME", Text = "BSME" },
                new SelectListItem { Value = "BTVETED", Text = "BTVETED" }
            };
            ViewBag.Courses = courses;
            return RedirectToAction();
        }
        public IActionResult Edit()
        {
            return RedirectToAction();
        }
        public IActionResult Delete()
        {
            return RedirectToAction();
        }
    }
}

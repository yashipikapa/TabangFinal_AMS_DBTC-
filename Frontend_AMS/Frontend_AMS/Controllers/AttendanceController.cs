using Microsoft.AspNetCore.Mvc;

namespace Frontend_AMS.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

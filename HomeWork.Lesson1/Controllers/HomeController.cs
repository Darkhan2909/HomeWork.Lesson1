using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Lesson1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var osname = Environment.OSVersion.Version.ToString();
            ViewBag.osname = osname;
            return View();
        }
    }
}

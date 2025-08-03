using Microsoft.AspNetCore.Mvc;

namespace Week1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

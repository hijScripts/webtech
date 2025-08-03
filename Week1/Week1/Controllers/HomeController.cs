using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Week1.Models;

namespace Week1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //throw new Exception("This is an error!");
            return View();
        }

        public IActionResult Test(int? id, string text)
        {
            // manually get form data
            //var searchText = Request.Form["text"];

            // pass to the view
            ViewBag.id = id;
            ViewBag.searchText = text;

            return View();
        }

        public IActionResult RazorTest()
        {
            //throw new Exception("This is an error!");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

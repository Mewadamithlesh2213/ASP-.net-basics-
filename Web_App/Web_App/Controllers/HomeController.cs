using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_App.Models;

namespace Web_App.Controllers
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
            Student student = new Student()
            {
                id = 101,
                name = "Mithlesh",
                age = 21,
                dept = "IT",
                course = "B.tech",
                mark = 99,
            };

            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUS()
        {
            return View();
        }
        public IActionResult ContactUs()
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

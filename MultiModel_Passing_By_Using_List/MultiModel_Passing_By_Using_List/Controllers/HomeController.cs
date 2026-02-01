using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MultiModel_Passing_By_Using_List.Models;

namespace MultiModel_Passing_By_Using_List.Controllers
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
            return View();
        }
        public IActionResult ShowStudent_Details()
        {
            List<Student> studentList = new List<Student>()
             {
              new Student { Id = 1, Name = "Rahul", Gender = "Male", Age = 21 },
              new Student { Id = 2, Name = "Priya", Gender = "Female", Age = 20 },
              new Student { Id = 3, Name = "Amit", Gender = "Male", Age = 22 },
              new Student { Id = 4, Name = "Sneha", Gender = "Female", Age = 21 }

             };
            return View(studentList);
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

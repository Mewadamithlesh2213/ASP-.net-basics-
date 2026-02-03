using Microsoft.AspNetCore.Mvc;

namespace Empty_Project_Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

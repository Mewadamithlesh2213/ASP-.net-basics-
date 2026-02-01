using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Passing_Data_From_Model_To_View.Models;

namespace Passing_Data_From_Model_To_View.Controllers
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
            // Yahh Tarika Purana hai ok Ab Ke Time Me
            // Nichee Wala SynTax Follow Krte Hai 



            //    var p = new Product();
            //    p.ProdId = 1;
            //    p.ProdName = "SunScreen";
            //    p.ProdPrice = 250;
            //    p.ProdQty = 5;

            //return View(p);

            var p = new Product()
            {
                ProdQty = 1,
                ProdId = 1,
                ProdName = "SunScreen",
                ProdPrice = 250,
            };

            return View(p);
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

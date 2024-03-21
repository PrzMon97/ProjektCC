using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherOnMarsApp.Models;

namespace WeatherOnMarsApp.Controllers
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
            /*  dane do testowania - autoscaling
            var start = DateTime.Now;
            long number = 954759790987450999;
            bool IsPrime = true;
            for (long i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            var end = DateTime.Now;

            ViewBag.Number = number;
            ViewBag.IsPrime = IsPrime;
            ViewBag.Elapsed = (end - start).ToString();



          !!!  wklej poni¿szy kod do view-home-index:

            <div class="text-center">
    <h3> test:</h3>
    <p>Number: @ViewBag.Number</p>
    <p>Prime: @ViewBag.IsPrime</p>
    <p>Elapsed: @ViewBag.Elapsed</p>
</div>

            */

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

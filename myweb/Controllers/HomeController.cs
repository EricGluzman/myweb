using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myweb.Models;

namespace myweb.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Tables()
        {
            return View();
        }   
        public IActionResult Features()
        {
            return View();
        }   
        public IActionResult Bids()
        {
            return View();
        }   
        public IActionResult Cars()
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

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myweb.Models;
using Microsoft.EntityFrameworkCore;   
using myweb.Data;                       
namespace myweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Bids()
        {
            var bids = _db.Bids
                          .Include(b => b.Client)   // also load the client of each bid
                          .Include(b => b.Car)      // also load the car of each bid
                          .ToList();
            return View(bids);                      // send the list to the view
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

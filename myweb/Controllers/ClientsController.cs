using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myweb.Data;

namespace myweb.Controllers
{
    public class ClientsController : Controller
    {
        private readonly AppDbContext _db;

        // ASP.NET gives us the AppDbContext automatically (registered in Program.cs)
        public ClientsController(AppDbContext db)
        {
            _db = db;
        }

        // GET: /Clients
        public IActionResult Index()
        {
            var clients = _db.Clients.Include(c => c.Bids).ToList();
            return View(clients);
        }
    }
}

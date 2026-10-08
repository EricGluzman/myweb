using Microsoft.AspNetCore.Mvc;
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
            var clients = _db.Clients.ToList();
            return View(clients);
        }
    }
}

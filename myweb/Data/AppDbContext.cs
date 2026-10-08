using Microsoft.EntityFrameworkCore;
using myweb.Models;

namespace myweb.Data
{
    // The bridge between our C# classes and the SQL Server database
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}

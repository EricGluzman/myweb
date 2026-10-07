using Microsoft.EntityFrameworkCore;
using myweb.Models;

namespace myweb.Data
{
    // The bridge between our C# classes and the SQL Server database
    public class AppDbContext : DbContext
    {
        // The options (which database to use) come from Program.cs
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Each DbSet = one table in the database
        public DbSet<Client> Clients { get; set; }
    }
}

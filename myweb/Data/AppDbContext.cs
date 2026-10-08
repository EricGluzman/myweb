using Microsoft.EntityFrameworkCore;
using myweb.Models;

namespace myweb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bid> Bids { get; set; } 
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, FullName = "Daniel Cohen", Email = "daniel.cohen@gmail.com", Phone = "050-1234567", JoinDate = new DateTime(2025, 3, 12) },
                new Client { Id = 2, FullName = "Noa Levi", Email = "noa.levi@gmail.com", Phone = "052-7654321", JoinDate = new DateTime(2025, 6, 1) },
                new Client { Id = 3, FullName = "Yossi Mizrahi", Email = "yossi.m@walla.co.il", Phone = "054-1112233", JoinDate = new DateTime(2025, 9, 20) },
                new Client { Id = 4, FullName = "Maya Friedman", Email = "maya.f@gmail.com", JoinDate = new DateTime(2026, 1, 8) },
                new Client { Id = 5, FullName = "Avi Peretz", Email = "avi.peretz@hotmail.com", Phone = "053-9988776", JoinDate = new DateTime(2026, 4, 15) }
            );
        }
    }
}

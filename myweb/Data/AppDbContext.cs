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
            // clients
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, FullName = "Daniel Cohen", Email = "daniel.cohen@gmail.com", Phone = "050-1234567", JoinDate = new DateTime(2025, 3, 12) },
                new Client { Id = 2, FullName = "Noa Levi", Email = "noa.levi@gmail.com", Phone = "052-7654321", JoinDate = new DateTime(2025, 6, 1) },
                new Client { Id = 3, FullName = "Yossi Mizrahi", Email = "yossi.m@walla.co.il", Phone = "054-1112233", JoinDate = new DateTime(2025, 9, 20) },
                new Client { Id = 4, FullName = "Maya Friedman", Email = "maya.f@gmail.com", JoinDate = new DateTime(2026, 1, 8) },
                new Client { Id = 5, FullName = "Avi Peretz", Email = "avi.peretz@hotmail.com", Phone = "053-9988776", JoinDate = new DateTime(2026, 4, 15) }
            );
            // Cars
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Brand = "Toyota", Model = "Corolla", Year = 2022, PricePerDay = 180 },
                new Car { Id = 2, Brand = "Kia", Model = "Picanto", Year = 2023, PricePerDay = 120 },
                new Car { Id = 3, Brand = "Tesla", Model = "Model 3", Year = 2024, PricePerDay = 350 }
            );

            // Features
            modelBuilder.Entity<Feature>().HasData(
                new Feature { Id = 1, Name = "GPS", Description = "Navigation system" },
                new Feature { Id = 2, Name = "AC", Description = "Air conditioning" },
                new Feature { Id = 3, Name = "Bluetooth", Description = "Phone connection" }
            );

            // Bids (one-to-many: each bid points to a client and a car by Id)
            modelBuilder.Entity<Bid>().HasData(
                new Bid { Id = 1, Amount = 200, BidDate = new DateTime(2026, 10, 1), ClientId = 1, CarId = 1 },
                new Bid { Id = 2, Amount = 220, BidDate = new DateTime(2026, 10, 2), ClientId = 2, CarId = 1 },
                new Bid { Id = 3, Amount = 400, BidDate = new DateTime(2026, 10, 3), ClientId = 3, CarId = 3 }
            );

            // Car ↔ Feature (many-to-many: fill the middle table CarFeature)
            modelBuilder.Entity<Car>()
                .HasMany(c => c.Features)
                .WithMany(f => f.Cars)
                .UsingEntity(j => j.HasData(
                    new { CarsId = 1, FeaturesId = 1 },   // Corolla has GPS
                    new { CarsId = 1, FeaturesId = 2 },   // Corolla has AC
                    new { CarsId = 3, FeaturesId = 1 },   // Tesla has GPS
                    new { CarsId = 3, FeaturesId = 3 }    // Tesla has Bluetooth
                ));

        }
    }
}

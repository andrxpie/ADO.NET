using Microsoft.EntityFrameworkCore;

namespace Loadings
{
    public class ShopDB : DbContext
    {
        public ShopDB() : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine" },
                new Country() { Id = 2, Name = "USA" },
                new Country() { Id = 3, Name = "Poland" },
                new Country() { Id = 4, Name = "Switzerland" },
                new Country() { Id = 5, Name = "German" },
                new Country() { Id = 6, Name = "Turkey" },
                new Country() { Id = 7, Name = "Japan" },
                new Country() { Id = 8, Name = "China" },
                new Country() { Id = 9, Name = "Greenland" },
                new Country() { Id = 10, Name = "Iceland" },
                new Country() { Id = 11, Name = "UK" },
            });

            modelBuilder.Entity<City>().HasData(new[]
            {
                new City() { Id = 1, Name = "Rivne", CountryId = 1 },
                new City() { Id = 2, Name = "New York", CountryId = 2 },
                new City() { Id = 3, Name = "Katowice", CountryId = 3 },
                new City() { Id = 4, Name = "Geneva", CountryId = 4 },
                new City() { Id = 5, Name = "Gamburg", CountryId = 5 },
                new City() { Id = 6, Name = "Denzili", CountryId = 6 },
                new City() { Id = 7, Name = "Tokyo", CountryId = 7 },
                new City() { Id = 8, Name = "Hong Kong", CountryId = 8 },
                new City() { Id = 9, Name = "Nuuk", CountryId = 9 },
                new City() { Id = 10, Name = "Hofn", CountryId = 10 },
                new City() { Id = 11, Name = "London", CountryId = 11 },
            });

            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Drink" },
                new Category() { Id = 2, Name = "Eat" },
                new Category() { Id = 3, Name = "Cloth" },
                new Category() { Id = 4, Name = "Electronic" },
                new Category() { Id = 5, Name = "For Home" },
            });
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
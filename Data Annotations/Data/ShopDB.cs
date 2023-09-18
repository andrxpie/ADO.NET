using Microsoft.EntityFrameworkCore;

namespace Data_Annotations
{
    public class ShopDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopDB;Integrated Security=True;Connect Timeout=2;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CountryCfgs());
            modelBuilder.ApplyConfiguration(new CityCfgs());
            modelBuilder.ApplyConfiguration(new ShopCfgs());
            modelBuilder.ApplyConfiguration(new WorkerCfgs());
            modelBuilder.ApplyConfiguration(new PositionCfgs());
            modelBuilder.ApplyConfiguration(new ProductCfgs());
            modelBuilder.ApplyConfiguration(new CategoryCfgs());
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
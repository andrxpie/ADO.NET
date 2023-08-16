using Entity_Framework_Intro.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Intro
{
    public class MusicPlayer : DbContext
    {
        public MusicPlayer() : base()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicPlayer;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() { Id = 1, Name = "Phonk" },
                new Genre() { Id = 2, Name = "Rock" },
                new Genre() { Id = 3, Name = "Hip-Hop & Rap" },
                new Genre() { Id = 4, Name = "Country" },
                new Genre() { Id = 5, Name = "R&B" },
                new Genre() { Id = 6, Name = "Folk" },
                new Genre() { Id = 7, Name = "Jazz" },
                new Genre() { Id = 8, Name = "Heavy Metal" },
                new Genre() { Id = 9, Name = "EDM" },
                new Genre() { Id = 10, Name = "Soul" }
            });

            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Phonk" },
                new Category() { Id = 2, Name = "My Favourite" },
                new Category() { Id = 3, Name = "Sport" },
                new Category() { Id = 4, Name = "Sleep" },
                new Category() { Id = 5, Name = "Work" },
            });

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
        }

        DbSet<Country> Countries { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Artist> Artists { get; set; }
        DbSet<Album> Albumns { get; set; }
        DbSet<Track> Tracks { get; set; }
        DbSet<Playlist> Playlists { get; set; }
    }
}
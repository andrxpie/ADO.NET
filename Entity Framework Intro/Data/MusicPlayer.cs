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
            //Database.EnsureCreated();
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

            modelBuilder.Entity<Artist>().HasData(new[]
            {
                new Artist() { Id = 1, CountryId = 1, Surname = "MoonDeity" }
            });

            modelBuilder.Entity<Album>().HasData(new []
            {
                new Album() { Id = 1, Name = "Debuti of Soul", ArtistId = 1, GenreId = 1, Rating = 10, Year = 2023 }
            });

            modelBuilder.Entity<Track>().HasData(new[]
            {
                new Track() { Id = 1, AlbumId = 1, Listens = 15, Name = "MOVEMENT", Rating = 10, Duration = new TimeSpan(0, 2, 30) },
                new Track() { Id = 2, AlbumId = 1, Listens = 1, Name = "POOR", Rating = 9, Duration = new TimeSpan(0, 1, 10) }
            });
        }

        public void CreateNewPlaylist()
        {
            Console.Clear();
            Console.Write("> Create New Playlist\n Name: "); string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Choose Category:");
            foreach (var item in Categories)
                Console.WriteLine($"[{item.Id}] {item.Name}");
            Console.Write("?: "); int categoryId = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int musicId = Tracks.Count();
            ICollection<Track> tracks;
            while(musicId != 0)
            {
                Console.WriteLine("> Add tracks:");
                foreach (var item in Tracks)
                    Console.WriteLine(item);
                Console.Write("? (type 0 to stop adding): ");
                musicId = Convert.ToInt32(Console.ReadLine());
            }

            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
    }
}
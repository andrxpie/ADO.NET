using Entity_Framework_Intro.Data;
using Entity_Framework_Intro.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicPlayer db = new MusicPlayer();
            db.Tracks.Add(new Track()
            {
                Name = "Neon Blade",
                Duration = new TimeSpan(0, 2, 20),
                Listens = 15,
                Rating = 10
            });
            
            db.Tracks.Add(new Track()
            {
                Name = "Neon Blade 2",
                Duration = new TimeSpan(0, 3, 15),
                Listens = 135,
                Rating = 130
            });

            db.CreateNewPlaylist();

            // 1
            //Album album1 = new Album() { Id = 1, Name = "Debuti of Soul", ArtistId = 1, GenreId = 1, Rating = 10, Year = 2023};
            //string playListName1 = Console.ReadLine();
            //var showTracks1 = db.Tracks.Where(x => x.Album.Name == playListName1 && x.Listens > db.Tracks.Average(y => y.Listens));

            // 2
            //string surname = "MoonDeity";
            //var showTracks2 = db.Tracks.Where(x => x.Album.Artist.Surname == surname).OrderByDescending(x => x.Rating).Take(3);
            //var showAlbums2 = db.Albums.Where(x => x.Artist.Surname == surname).OrderByDescending(x => x.Rating).Take(3);

            // 3
            //string trackName = "OVEMENT";
            //string trackLyrics = "FAST";
            //var showTracks3 = db.Tracks.Where(x => x.Name.Contains(trackName) || x.Lyrics.Contains(trackLyrics));

            //RestaurantDbContext db = new RestaurantDbContext();

            //db.Employees.Add(new()
            //{
            //    Name = "Andrii",
            //    PositionId = 2,
            //    Surname = "Povar",
            //    Birthdate = new DateTime(1988, 4, 10)
            //});

            //db.Dishes.Add(new Dish()
            //{
            //    Price = 145,
            //    Title = "Lobsters",
            //    Weight = 220,
            //    Description = "I like it!"
            //});

            //db.SaveChanges();

            //var data = db.Dishes.Where(x => x.Price < 1000).OrderBy(x => x.Weight);

            //foreach (var i in data)
            //{
            //    Console.WriteLine($"Dish {i.Title} - {i.Price}$ {i.Weight}g");
            //}
        }
    }
}
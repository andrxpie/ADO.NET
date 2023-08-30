using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class SpotifyLiteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsersCfgs());
            modelBuilder.ApplyConfiguration(new ArtistsCfgs());
            modelBuilder.ApplyConfiguration(new AlbumsCfgs());
            modelBuilder.ApplyConfiguration(new TracksCfgs());
            modelBuilder.ApplyConfiguration(new PlaylistsCfgs());
            modelBuilder.ApplyConfiguration(new CountriesCfgs());
            modelBuilder.ApplyConfiguration(new CategoriesCfgs());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set;}
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

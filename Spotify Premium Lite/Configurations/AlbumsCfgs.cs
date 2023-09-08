using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class AlbumsCfgs : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            
            builder.HasMany(x => x.Tracks).WithOne(x => x.Album).HasForeignKey(x => x.AlbumId);

            builder.HasData(new[]
            {
                new Album { Id = 1, Name = "Neon Blade", ArtistId = 1, Description = "Single", Listens = 4324156, Picture = "images\\Neon Blade.jpg" },
                new Album { Id = 2, Name = "chaxs thexry", ArtistId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Listens = 927523, Picture = "images\\chaxs thexry.jpg" },
                new Album { Id = 3, Name = "PSYCHX", ArtistId = 2, Listens = 734634, Picture = "images\\psychx.jpg" },
                new Album { Id = 4, Name = "Burst", ArtistId = 3, Description = "Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light.", Listens = 5 }
            });
        }
    }
}
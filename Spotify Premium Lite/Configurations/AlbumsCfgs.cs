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
                new Album { Id = 1, Name = "Neon Blade", ArtistId = 1, Description = "Single", Listens = 4324156, Picture = "https://i.scdn.co/image/ab67616d00001e0233364d6b6fd36894f1a3b506" },
                new Album { Id = 2, Name = "chaxs thexry", ArtistId = 2, Listens = 927523, Picture = "https://i.scdn.co/image/ab67616d00001e0287a9495fd25dfa23e68a9e66" },
                new Album { Id = 3, Name = "PSYCHX", ArtistId = 2, Listens = 734634, Picture = "https://i.scdn.co/image/ab67616d00001e02be40ee61162ba11a45328795" },
                new Album { Id = 4, Name = "Burst", ArtistId = 3, Description = "Faster than Light", Listens = 5, Picture = "https://th.bing.com/th?id=OSK.HNYBhQCCy91WIww1kvaZoVZmKw7TBLm9c8pWdTBe305ZU5U&w=122&h=122&c=7&o=6&oif=webp&pid=SANGAM" }
            });
        }
    }
}

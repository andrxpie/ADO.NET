using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class TracksCfgs : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Picture).IsRequired();

            builder.HasData(new[]
            {
                new Track { Id = 1, Name = "Neon Blade", Duration = new TimeSpan(0, 2, 30), Picture = "https://i.scdn.co/image/ab67616d00001e0233364d6b6fd36894f1a3b506", Listens = 15523064, AlbumId = 1 },
                new Track { Id = 2, Name = "Neon Blade 2", Duration = new TimeSpan(0, 1, 45), Picture = "https://i.scdn.co/image/ab67616d00001e0200c44aebaaa37ef468709f01", Listens = 5553236, AlbumId = 1 },
                new Track { Id = 3, Name = "King, Scar.", Duration = new TimeSpan(0, 3, 40), Picture = "https://i.scdn.co/image/ab67616d00001e0287a9495fd25dfa23e68a9e66", Listens = 35275927, AlbumId = 2 },
                new Track { Id = 4, Name = "Chain$Aw", Duration = new TimeSpan(0, 3, 32), Picture = "https://i.scdn.co/image/ab67616d00001e0287a9495fd25dfa23e68a9e66", Listens = 5835259, AlbumId = 2 },
                new Track { Id = 5, Name = "MISS ME?", Duration = new TimeSpan(0, 2, 13), Picture = "https://i.scdn.co/image/ab67616d00001e02be40ee61162ba11a45328795", Listens = 734574, AlbumId = 3 },
            });
        }
    }
}

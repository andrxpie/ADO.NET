using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class ArtistsCfgs : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Surname).IsRequired();
            
            builder.HasOne(x => x.Country).WithMany(x => x.Artists).HasForeignKey(x => x.CountryId);
            builder.HasMany(x => x.Albums).WithOne(x => x.Artist).HasForeignKey(x => x.ArtistId);

            builder.HasData(new[]
            {
                new Artist { Id = 1, Name = "Eduard", Surname = "Vodovozyk", Nickname = "MoonDeity", Description = "UA Phonkmaker", Listens = 312412, CountryId = 1 },
                new Artist { Id = 2, Name = "Marius", Surname = "Listhrop", Nickname = "Scarlxrd", Description = "DEMOCRATION", Listens = 51523412, CountryId = 2 },
                new Artist { Id = 3, Name = "Donkey", Surname = "Downey", Nickname = "Stark", Listens = 142, CountryId = 3 }
            });
        }
    }
}

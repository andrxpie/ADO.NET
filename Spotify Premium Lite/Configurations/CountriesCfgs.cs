using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class CountriesCfgs : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();

            builder.HasData(new[]
            {
                new Country { Id = 1, Name = "Ukraine" },
                new Country { Id = 2, Name = "USA" },
                new Country { Id = 3, Name = "UK" },
                new Country { Id = 4, Name = "Italy" },
                new Country { Id = 5, Name = "China" },
                new Country { Id = 6, Name = "South Korea" },
                new Country { Id = 7, Name = "North Korea" },
                new Country { Id = 8, Name = "Poland" },
                new Country { Id = 9, Name = "Czech" },
                new Country { Id = 10, Name = "German" },
                new Country { Id = 11, Name = "Belgium" },
                new Country { Id = 12, Name = "Switzerland" },
                new Country { Id = 13, Name = "Iceland" },
                new Country { Id = 14, Name = "Greenland" },
                new Country { Id = 15, Name = "Canada" },
                new Country { Id = 16, Name = "Brazil" },
                new Country { Id = 17, Name = "Estonia" },
                new Country { Id = 18, Name = "Afghanistan" },
                new Country { Id = 19, Name = "Japan" },
            });
        }
    }
}
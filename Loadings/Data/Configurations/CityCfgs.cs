using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Loadings
{
    public class CityCfgs : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.HasData(new[]
            {
                new City() { Id = 1, Name = "Rivne", CountryId = 1 },
                new City() { Id = 2, Name = "New York", CountryId = 2 },
                new City() { Id = 3, Name = "Katowice", CountryId = 3 },
                new City() { Id = 4, Name = "Geneva", CountryId = 4 },
                new City() { Id = 5, Name = "Gamburg", CountryId = 5 },
                new City() { Id = 6, Name = "Denzili", CountryId = 6 },
                new City() { Id = 7, Name = "Tokyo", CountryId = 7 },
                new City() { Id = 8, Name = "Hong Kong", CountryId = 8 },
                new City() { Id = 9, Name = "Nuuk", CountryId = 9 },
                new City() { Id = 10, Name = "Hofn", CountryId = 10 },
                new City() { Id = 11, Name = "London", CountryId = 11 },
            });

            builder.HasKey(x => x.Id).HasName("Cities");
            builder.HasMany(x => x.Shops).WithOne(x => x.City).IsRequired().HasForeignKey(x => x.CityId);
        }
    }
}

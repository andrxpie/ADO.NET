using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class CategoriesCfgs : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();

            builder.HasData(new[]
            {
                new Category { Id = 1, Name = "Phonk" },
                new Category { Id = 2, Name = "Instrumental" },
                new Category { Id = 3, Name = "Race" },
                new Category { Id = 4, Name = "Hip & Hop" },
                new Category { Id = 5, Name = "Heavy Metal" },
                new Category { Id = 6, Name = "Opera" },
                new Category { Id = 7, Name = "Bass" },
                new Category { Id = 8, Name = "Ambient" },
                new Category { Id = 9, Name = "Chill-out" },
                new Category { Id = 10, Name = "Rock & Roll" },
                new Category { Id = 11, Name = "Disco" },
                new Category { Id = 12, Name = "Hardcore" },
                new Category { Id = 13, Name = "Funk" },
                new Category { Id = 14, Name = "Jungle" },
                new Category { Id = 15, Name = "Punk" },
                new Category { Id = 16, Name = "Chopped and screwed" },
                new Category { Id = 17, Name = "Industrial" },
                new Category { Id = 18, Name = "Dubstep" },
                new Category { Id = 19, Name = "Electro" },
                new Category { Id = 20, Name = "Techno" },
            });
        }
    }
}

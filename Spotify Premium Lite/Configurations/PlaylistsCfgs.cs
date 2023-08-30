using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class PlaylistsCfgs : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.IsPublic).IsRequired();

            builder.HasOne(x => x.Creator).WithMany(x => x.Playlists).HasForeignKey(x => x.CreatorId);
            builder.HasMany(x => x.Tracks).WithMany(x => x.Playlists);
            builder.HasOne(x => x.Category).WithMany(x => x.Playlists).HasForeignKey(x => x.CategoryId);

            builder.HasData(new[]
            {
                new Playlist { Id = 1, Name = "Phonk", Description = "For fight", IsPublic = false, CreatorId = 1, CategoryId = 1 },
                new Playlist { Id = 2, Name = "Good night", Description = "Sleep", IsPublic = true, CreatorId = 1, CategoryId = 2 },
                new Playlist { Id = 3, Name = "FASTER", Description = "Races", IsPublic = true, CreatorId = 2, CategoryId = 1 },
            });
        }
    }
}
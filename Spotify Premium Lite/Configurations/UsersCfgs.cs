using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class UsersCfgs : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Login).IsRequired();
            builder.Property(x => x.Password).IsRequired();

            builder.HasData(new[]
            {
                new User { Id = 1, Login = "login1", Password = "password1", Email = "super@google.com", Nickname = "greatestGoogleUser" },
                new User { Id = 2, Login = "1nigol", Password = "1drowssap", Email = "repus@elgoog.moc", Nickname = "resUelgooGtsetaerg" },
                new User { Id = 3, Login = "log", Password = "pas", Nickname = "s1mple", Avatar = "https://i.scdn.co/image/ab67757000003b82368223ebc3bb84b274fc8365" }
            });
        }
    }
}
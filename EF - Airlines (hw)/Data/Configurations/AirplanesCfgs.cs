using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class AirplanesCfgs : IEntityTypeConfiguration<Airplanes>
    {
        public void Configure(EntityTypeBuilder<Airplanes> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Model).IsRequired();
            builder.HasOne(x => x.Type).WithMany(x => x.Airlplanes).HasForeignKey(x => x.TypeId).IsRequired();
            builder.HasOne(x => x.Country).WithMany(x => x.Airplanes).HasForeignKey(x => x.CountryId).IsRequired();
            builder.HasMany(x => x.Flights).WithOne(x => x.Airplane).HasForeignKey(x => x.AirplaneId);
        }
    }
}

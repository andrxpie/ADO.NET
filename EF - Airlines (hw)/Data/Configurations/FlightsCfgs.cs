using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class FlightsCfgs : IEntityTypeConfiguration<Flights>
    {
        public void Configure(EntityTypeBuilder<Flights> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.ArivalDate).IsRequired();
            builder.Property(x => x.DepartureDate).IsRequired();
            builder.Property(x => x.ArivalCity).IsRequired();
            builder.Property(x => x.DepartureCity).IsRequired();

            builder.HasMany(x => x.Clients).WithMany(x => x.Flights);
        }
    }
}

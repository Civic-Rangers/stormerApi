using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities;

namespace Repository.Configuration
{
    public class FloodZoneConfiguration : IEntityTypeConfiguration<FloodZone>
    {
        public void Configure(EntityTypeBuilder<FloodZone> builder)
        {
            //builder.HasData(
            //    new FloodZone
            //    {
            //        Id = Guid.NewGuid(),
            //        Address = "123 River St"
            //    },
            //    new FloodZone
            //    {
            //        Id = Guid.NewGuid(),
            //        Address = "456 Lakeview Dr"
            //    },
            //    new FloodZone
            //    {
            //        Id = Guid.NewGuid(),
            //        Address = "789 Ocean Ave"
            //    }
            //);
        }
    }
}

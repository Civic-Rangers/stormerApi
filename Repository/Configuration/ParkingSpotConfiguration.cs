using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities;

namespace Repository.Configuration
{
    public class ParkingSpotConfiguration : IEntityTypeConfiguration<ParkingSpot>
    {
        public void Configure(EntityTypeBuilder<ParkingSpot> builder)
        {
            builder.HasData(
                new ParkingSpot
                {
                    Id = Guid.NewGuid(),
                    Address = "Spot 101",
                    IsFilled = true,
                },
                new ParkingSpot
                {
                    Id = Guid.NewGuid(),
                    Address = "Spot 202",
                    IsFilled = false
                },
                new ParkingSpot
                {
                    Id = Guid.NewGuid(),
                    Address = "Spot 303",
                    IsFilled = true
                }
            );
        }
    }
}

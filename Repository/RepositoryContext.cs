using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Repository.Configuration;


namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }
     
        public DbSet<User> Users { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<FloodZone> FloodZones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User Configuration
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Name).IsRequired().HasMaxLength(100);
            });

            // ParkingSpot Configuration
            modelBuilder.Entity<ParkingSpot>(entity =>
            {
                entity.HasKey(ps => ps.Id);
                entity.Property(ps => ps.Address).IsRequired();
                entity.HasOne(ps => ps.User)
                    .WithMany(u => u.ParkingSpots)
                    .HasForeignKey(ps => ps.UserId);
            });

            // FloodZone Configuration
            modelBuilder.Entity<FloodZone>(entity =>
            {
                entity.HasKey(fz => fz.Id);
                entity.Property(fz => fz.Address).IsRequired();
                entity.HasOne(fz => fz.User)
                    .WithMany()
                    .HasForeignKey(fz => fz.UserId);
            });

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ParkingSpotConfiguration());
            modelBuilder.ApplyConfiguration(new FloodZoneConfiguration());
        }
    }
}

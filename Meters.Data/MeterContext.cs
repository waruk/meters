using Meters.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meters.Data
{
    public class MeterContext : DbContext
    {
        public MeterContext(DbContextOptions<MeterContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Meter> Meters { get; set; }
        public DbSet<Index> Indexes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meter>().HasData(
                new Meter
                {
                    MeterId = 1,
                    SerialNumber = "TestBathroomColdWater",
                    ResourceType = MeteredResource.ColdWater,
                    Location = MeterLocation.Bathroom
                },
                new Meter
                {
                    MeterId = 2,
                    SerialNumber = "TestBathroomHotWater",
                    ResourceType = MeteredResource.HotWater,
                    Location = MeterLocation.Bathroom
                },
                new Meter
                {
                    MeterId = 3,
                    SerialNumber = "TestKitchenColdWater",
                    ResourceType = MeteredResource.ColdWater,
                    Location = MeterLocation.Kitchen
                },
                new Meter
                {
                    MeterId = 4,
                    SerialNumber = "TestKitchenHotWater",
                    ResourceType = MeteredResource.HotWater,
                    Location = MeterLocation.Kitchen
                }
            );
        }

    }

}

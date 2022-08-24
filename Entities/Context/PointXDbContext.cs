using Microsoft.EntityFrameworkCore;

namespace PointX.Entities.Context

{
    public class PointXDbContext : DbContext
    {
        public PointXDbContext(DbContextOptions<PointXDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Nation> Nations { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<WardStreet> Ward_Street { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Street> Streets { get; set; }
    }
}

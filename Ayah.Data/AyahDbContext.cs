using Microsoft.EntityFrameworkCore;
using Ayah.Core.Models;
using Ayah.Data.Configurations;

namespace Ayah.Data
{
    public class AyahDbContext : DbContext
    {
        public DbSet<Employee> Musics { get; set; }
        public DbSet<Gender> Artists { get; set; }

        public DbSet<Town> Musics { get; set; }
        public DbSet<Nationality> Artists { get; set; }

        public AyahDbContext(DbContextOptions<AyahDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new EmployeeConfiguration());

            builder
                .ApplyConfiguration(new GenderConfiguration());

            builder
                .ApplyConfiguration(new NationalityConfiguration());

            builder
                .ApplyConfiguration(new TownConfiguration());
        }
    }
}
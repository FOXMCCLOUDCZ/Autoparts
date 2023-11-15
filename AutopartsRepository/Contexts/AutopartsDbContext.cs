using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.ExtensionForUsers.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AutopartsRepository.Contexts
{
    public class AutopartsDbContext : DbContext
    {
        public AutopartsDbContext(DbContextOptions options) : base(options)
        {
        }

        public AutopartsDbContext()
        {
        }

        // DbSet -> AutopartsEntity/ExtensionForUser/Entities
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }


        // DbSet -> AutopartsEntity/Catalog/Entities
        public DbSet<Warranty> Warranties { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using MyBody.Domain;


namespace MyBody.infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BodyComposition> Compositions { get; set; }
        public DbSet<BodyMeasurements> Measurements { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { 

        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            
        }

    }
}

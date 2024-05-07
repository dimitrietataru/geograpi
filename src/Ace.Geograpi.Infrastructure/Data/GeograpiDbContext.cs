using Ace.Geograpi.Infrastructure.Data.Configurations;
using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data;

internal sealed class GeograpiDbContext : DbContext
{
    public GeograpiDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<ContinentEntity> Continents { get; set; }
    public DbSet<CountryEntity> Counties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected sealed override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ////modelBuilder.ApplyConfigurationsFromAssembly(typeof(IInfrastructureMarker).Assembly);

        modelBuilder.ApplyConfiguration(ContinentConfiguration.Instance);
        modelBuilder.ApplyConfiguration(CountryConfiguration.Instance);
    }
}

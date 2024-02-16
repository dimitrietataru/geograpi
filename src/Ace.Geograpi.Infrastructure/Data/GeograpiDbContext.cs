using Ace.Geograpi.Infrastructure.Data.Configurations;
using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data;

internal sealed class GeograpiDbContext : DbContext
{
    public GeograpiDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ////modelBuilder.ApplyConfigurationsFromAssembly(typeof(IInfrastructureMarker).Assembly);

        modelBuilder.ApplyConfiguration(ContinentConfiguration.Instance);
        modelBuilder.ApplyConfiguration(CountryConfiguration.Instance);
    }

    public DbSet<ContinentEntity> Continents { get; set; }
    public DbSet<CountryEntity> Counties { get; set; }
}

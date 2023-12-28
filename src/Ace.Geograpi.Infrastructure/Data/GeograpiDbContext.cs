using Ace.Geograpi.Infrastructure.Data.Entities;

namespace Ace.Geograpi.Infrastructure.Data;

internal sealed class GeograpiDbContext : DbContext
{
    public GeograpiDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Continent> Continents { get; set; }
    public DbSet<Country> Counties { get; set; }
}

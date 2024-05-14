using Ace.Geograpi.Infrastructure.Data.Migrations.Interfaces;
using CatNip.Infrastructure.Data.Migrations;

namespace Ace.Geograpi.Infrastructure.Data.Migrations;

internal sealed class GeograpiMigrationProvider
    : EFCoreMigrationProvider<GeograpiDbContext>, IGeograpiMigrationProvider
{
    public GeograpiMigrationProvider(GeograpiDbContext dbContext)
        : base(dbContext)
    {
    }
}

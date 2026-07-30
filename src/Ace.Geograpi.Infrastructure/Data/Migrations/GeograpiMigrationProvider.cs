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

    public sealed override async Task MigrateAsync(CancellationToken cancellation = default)
    {
        var retryPolicy = Policy
            .Handle<NpgsqlException>()
            .WaitAndRetryAsync(3, retry => TimeSpan.FromSeconds(retry * 2));

        await retryPolicy.ExecuteAsync(() => base.MigrateAsync(cancellation));
    }
}

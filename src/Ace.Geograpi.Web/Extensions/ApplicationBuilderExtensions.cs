using Ace.Geograpi.Infrastructure.Data.Migrations.Interfaces;

namespace Ace.Geograpi.Web.Extensions;

public static class ApplicationBuilderExtensions
{
    public static async Task ApplyDbMigrationsAsync(
        this IApplicationBuilder app, CancellationToken cancellation = default)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var migrationProvider = scope.ServiceProvider.GetRequiredService<IGeograpiMigrationProvider>();

        await migrationProvider.MigrateAsync(cancellation);
    }
}

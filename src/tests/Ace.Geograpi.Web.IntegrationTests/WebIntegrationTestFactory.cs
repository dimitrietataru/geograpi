using Ace.Geograpi.Infrastructure.Data;

namespace Ace.Geograpi.Web.IntegrationTests;

public sealed class WebIntegrationTestFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private readonly PostgreSqlContainer dbContainer = new PostgreSqlBuilder()
        .WithImage("postgres:latest")
        .WithDatabase("geograpi")
        .WithUsername("postgres")
        .WithPassword("postgres")
        .Build();

    public async Task InitializeAsync()
    {
        await dbContainer.StartAsync();
    }

    async Task IAsyncLifetime.DisposeAsync()
    {
        await DisposeAsync();
    }

    public override async ValueTask DisposeAsync()
    {
        await dbContainer.StopAsync();

        await base.DisposeAsync();
    }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(
            services =>
            {
                var descriptor = services
                    .SingleOrDefault(s => s.ServiceType == typeof(DbContextOptions<GeograpiDbContext>));

                if (descriptor is not null)
                {
                    services.Remove(descriptor);
                }

                services.AddDbContext<GeograpiDbContext>(options =>
                {
                    options.UseNpgsql(
                        dbContainer.GetConnectionString(),
                        npgsqlOptions => npgsqlOptions.MigrationsAssembly("Ace.Geograpi.Infrastructure"));
                });
            });
    }
}

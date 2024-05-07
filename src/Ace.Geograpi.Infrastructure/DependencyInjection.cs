using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Infrastructure.Data;
using Ace.Geograpi.Infrastructure.Data.Migrations;
using Ace.Geograpi.Infrastructure.Data.Migrations.Interfaces;
using Ace.Geograpi.Infrastructure.Mappers;
using Ace.Geograpi.Infrastructure.Mappers.Traceable;
using Ace.Geograpi.Infrastructure.Repositories;
using Microsoft.Extensions.Hosting;

namespace Ace.Geograpi.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration, IHostEnvironment env)
    {
        services.AddDatabase(configuration, env);
        services.AddMappers();
        services.AddRepositories();
    }

    internal static void AddDatabase(this IServiceCollection services, IConfiguration configuration, IHostEnvironment env)
    {
        services.AddDbContext<GeograpiDbContext>(options =>
        {
            options.UseNpgsql(
                configuration.GetConnectionString("Database"),
                npgsqlOptions =>
                {
                    npgsqlOptions.MigrationsAssembly("Ace.Geograpi.Infrastructure");
                    ////npgsqlOptions.EnableRetryOnFailure();
                });

            if (env.IsDevelopment())
            {
                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            }
        });

        services.AddScoped<IGeograpiMigrationProvider, GeograpiMigrationProvider>();
    }

    internal static void AddMappers(this IServiceCollection services)
    {
        services.AddAutoMapper(config =>
        {
            config.AddProfile<TraceableIntMapper>();

            config.AddProfile<ContinentMappingProfile>();
            config.AddProfile<CountryMappingProfile>();
        });
    }

    internal static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IContinentRepository, ContinentRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
    }
}

using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Infrastructure.Data;
using Ace.Geograpi.Infrastructure.Data.Migrations;
using Ace.Geograpi.Infrastructure.Data.Migrations.Interfaces;
using Ace.Geograpi.Infrastructure.Mappers;
using Ace.Geograpi.Infrastructure.Mappers.Root;
using Ace.Geograpi.Infrastructure.Mappers.Traceable;
using Ace.Geograpi.Infrastructure.MessageBus.Consumers.Continents;
using Ace.Geograpi.Infrastructure.MessageBus.Consumers.Countries;
using Ace.Geograpi.Infrastructure.Repositories;

namespace Ace.Geograpi.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IHostApplicationBuilder builder)
    {
        builder.Services.AddDatabase(builder.Configuration, builder.Environment);
        builder.Services.AddMappers();
        builder.Services.AddRepositories();

        builder.Services.AddMassTransit(config =>
        {
            config.AddConsumer<ContinentCreatedEventConsumer, ContinentCreatedEventConsumerDefinition>();
            config.AddConsumer<ContinentUpdatedEventConsumer, ContinentUpdatedEventConsumerDefinition>();
            config.AddConsumer<ContinentDeletedEventConsumer, ContinentDeletedEventConsumerDefinition>();

            config.AddConsumer<CountryCreatedEventConsumer, CountryCreatedEventConsumerDefinition>();
            config.AddConsumer<CountryUpdatedEventConsumer, CountryUpdatedEventConsumerDefinition>();
            config.AddConsumer<CountryDeletedEventConsumer, CountryDeletedEventConsumerDefinition>();

            config.UsingRabbitMq((context, configure) =>
            {
                configure.Host(builder.Configuration.GetConnectionString("RabbitMQ"));

                configure.ConfigureEndpoints(context);
            });
        });
    }

    internal static void AddDatabase(
        this IServiceCollection services, IConfiguration configuration, IHostEnvironment env)
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
            config.AddProfile<ModelIntMappingProfile>();
            config.AddProfile<TraceableIntMappingProfile>();

            config.AddProfile<ContinentMappingProfile>();
            config.AddProfile<CountryMappingProfile>();

            config.AddProfile<ContinentRootMappingProfile>();
            config.AddProfile<CountryRootMappingProfile>();
        });
    }

    internal static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IContinentRepository, ContinentRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
    }
}

using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Infrastructure.Mappers;
using Ace.Geograpi.Infrastructure.Mappers.Traceable;
using Ace.Geograpi.Infrastructure.Repositories;

namespace Ace.Geograpi.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMappers();

        services.AddRepositories();
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

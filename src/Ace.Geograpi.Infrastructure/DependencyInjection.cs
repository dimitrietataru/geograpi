using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Infrastructure.Repositories;

namespace Ace.Geograpi.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRepositories();
    }

    internal static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IContinentRepository, ContinentRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
    }
}

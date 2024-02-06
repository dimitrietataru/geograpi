using Ace.Geograpi.Application.Services;
using Ace.Geograpi.Domain.Services;

namespace Ace.Geograpi.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddServices();
    }

    internal static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IContinentService, ContinentService>();
        services.AddScoped<ICountryService, CountryService>();
    }
}

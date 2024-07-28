using Ace.Geograpi.Application.Services;
using Ace.Geograpi.Domain.Services;

namespace Ace.Geograpi.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IHostApplicationBuilder builder)
    {
        builder.Services.AddAppServices();
    }

    private static void AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<IContinentService, ContinentService>();
        services.AddScoped<ICountryService, CountryService>();
    }
}

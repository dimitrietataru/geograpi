using Ace.Geograpi.Application.Services;
using Ace.Geograpi.Application.Validators;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Services;

namespace Ace.Geograpi.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IHostApplicationBuilder builder)
    {
        builder.Services.AddAppServices();
        builder.Services.AddValidators();
    }

    private static void AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<IContinentService, ContinentService>();
        services.AddScoped<ICountryService, CountryService>();
    }

    private static void AddValidators(this IServiceCollection services)
    {
        services.AddTransient<IValidator<ContinentModel>, ContinentModelValidator>();
        services.AddTransient<IValidator<CountryModel>, CountryModelValidator>();
    }
}

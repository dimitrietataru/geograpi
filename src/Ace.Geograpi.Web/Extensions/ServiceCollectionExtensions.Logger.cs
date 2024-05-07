using Serilog;

namespace Ace.Geograpi.Web.Extensions;

public static partial class ServiceCollectionExtensions
{
    public static void AddGeograpiLogger(this IServiceCollection services, IConfiguration configuration)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(formatProvider: CultureInfo.InvariantCulture)
            .CreateBootstrapLogger();

        services.AddSerilog((services, config) => config
            .MinimumLevel.Information()
            .ReadFrom.Configuration(configuration)
            .ReadFrom.Services(services)
            .Enrich.FromLogContext());
    }
}

using Serilog;

namespace Ace.Geograpi.Web;

public static partial class AppConfiguration
{
    public static void AddGeograpiLogger(this IHostApplicationBuilder builder)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(formatProvider: CultureInfo.InvariantCulture)
            .CreateBootstrapLogger();

        builder.Services.AddSerilog((services, config) => config
            .ReadFrom.Configuration(builder.Configuration)
            .ReadFrom.Services(services)
            .Enrich.FromLogContext());
    }

    public static void UseGeograpiLogger(this IApplicationBuilder app)
    {
        app.UseSerilogRequestLogging();
    }
}

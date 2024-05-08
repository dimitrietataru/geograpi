namespace Ace.Geograpi.Web;

public static partial class AppConfiguration
{
    public static void AddGeograpiApiVersioning(this IServiceCollection services)
    {
        services
            .AddApiVersioning(
                options =>
                {
                    options.AssumeDefaultVersionWhenUnspecified = true;
                    options.DefaultApiVersion = new ApiVersion(1, 0);
                    options.ReportApiVersions = true;
                })
            .AddApiExplorer(
                options =>
                {
                    options.GroupNameFormat = "'v'VVVV";
                    options.SubstituteApiVersionInUrl = true;
                });

        services.AddEndpointsApiExplorer();
    }
}

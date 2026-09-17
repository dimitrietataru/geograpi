namespace Ace.Geograpi.Web;

internal static partial class AppConfiguration
{
    public static void AddGeograpiApiVersioning(this IServiceCollection services)
    {
        services
            .AddApiVersioning(
                options =>
                {
                    options.ReportApiVersions = true;
                    options.ApiVersionReader = new UrlSegmentApiVersionReader();
                })
            .AddApiExplorer(
                options =>
                {
                    options.GroupNameFormat = "'v'VVVV";
                    options.SubstituteApiVersionInUrl = true;
                })
            .AddMvc();

        services.AddEndpointsApiExplorer();
    }
}

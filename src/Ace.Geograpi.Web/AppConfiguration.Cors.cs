namespace Ace.Geograpi.Web;

internal static partial class AppConfiguration
{
    internal const string CorsPolicyPermissive = "permissive";
    internal const string CorsPolicyRestrictive = "restrictive";

    public static void AddGeograpiCors(this IServiceCollection services)
    {
        services.AddCors(
            options =>
            {
                options.AddPolicy(
                    name: CorsPolicyPermissive,
                    configurePolicy: policyBuilder => policyBuilder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());

                options.AddPolicy(
                    name: CorsPolicyRestrictive,
                    configurePolicy: policyBuilder => policyBuilder
                        .WithOrigins([])
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });
    }

    public static void UseGeograpiCorsPermissive(this IApplicationBuilder app)
    {
        app.UseCors(CorsPolicyPermissive);
    }

    public static void UseGeograpiCorsRestrictive(this IApplicationBuilder app)
    {
        app.UseCors(CorsPolicyRestrictive);
    }
}

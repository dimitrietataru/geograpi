using Microsoft.OpenApi.Models;

namespace Ace.Geograpi.Web;

internal static partial class AppConfiguration
{
    public static void AddGeograpiSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(
            options =>
            {
                options.SwaggerDoc(
                    name: "v1.0",
                    info: new OpenApiInfo
                    {
                        Title = "Geography Open API v1.0",
                        Version = "v1.0"
                    });

                options.SwaggerDoc(
                    name: "v2.0",
                    info: new OpenApiInfo
                    {
                        Title = "Geography Open API v2.0",
                        Version = "v2.0"
                    });
            });
    }

    public static void UseGeograpiSwagger(this IApplicationBuilder app)
    {
        app.UseSwagger(
            options =>
            {
                options.RouteTemplate = "/swagger/{documentname}/swagger.json";
            });

        app.UseSwaggerUI(
            options =>
            {
                options.SwaggerEndpoint("/swagger/v1.0/swagger.json", "v1");
                options.SwaggerEndpoint("/swagger/v2.0/swagger.json", "v2");

                options.DocumentTitle = "Geography Open API - Swagger UI";
                options.RoutePrefix = "swagger";
                options.DisplayRequestDuration();
            });
    }
}

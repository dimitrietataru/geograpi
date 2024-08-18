using FluentValidation.AspNetCore;

namespace Ace.Geograpi.Web;

public static partial class AppConfiguration
{
    public static void AddGeograpiControllers(this IServiceCollection services)
    {
        services.AddControllers();

        services.AddFluentValidationAutoValidation(
            config =>
            {
                config.DisableDataAnnotationsValidation = true;
                ////config.ImplicitlyValidateChildProperties = true;
                ////config.ImplicitlyValidateRootCollectionElements = true;
            });
    }
}

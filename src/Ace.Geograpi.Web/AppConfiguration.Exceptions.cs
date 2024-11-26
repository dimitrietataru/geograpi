using Ace.Geograpi.Web.ExceptionHandlers;

namespace Ace.Geograpi.Web;

internal static partial class AppConfiguration
{
    public static void AddGeograpiExceptionHandlers(this IServiceCollection services)
    {
        services.AddProblemDetails();

        services.AddExceptionHandler<DataNotFoundExceptionHandler>();
        services.AddExceptionHandler<GlobalExceptionHandler>();
    }
}

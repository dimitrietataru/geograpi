using Ace.Geograpi.Web.Extensions.Logging;
using CatNip.Domain.Exceptions;

namespace Ace.Geograpi.Web.ExceptionHandlers;

internal sealed class DataNotFoundExceptionHandler : IExceptionHandler
{
    private readonly ILogger<DataNotFoundExceptionHandler> logger;

    public DataNotFoundExceptionHandler(ILogger<DataNotFoundExceptionHandler> logger)
    {
        this.logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        if (exception is not DataNotFoundException)
        {
            return false;
        }

        logger.LogDataNotFoundException(exception, exception.Message);

        var problemDetails = new ProblemDetails
        {
            Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.5",
            Status = StatusCodes.Status404NotFound,
            Title = "Not Found"
        };

        httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }
}

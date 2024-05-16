using static Microsoft.Extensions.Logging.LogLevel;

namespace Ace.Geograpi.Web.Extensions.Logging;

internal static partial class LoggerExtensions
{
    [LoggerMessage(Level = Error, Message = "Handling Exception: {Message}")]
    public static partial void LogGlobalException(this ILogger logger, Exception ex, string message);

    [LoggerMessage(Level = Error, Message = "Handling DataNotFoundException: {Message}")]
    public static partial void LogDataNotFoundException(this ILogger logger, Exception ex, string message);
}

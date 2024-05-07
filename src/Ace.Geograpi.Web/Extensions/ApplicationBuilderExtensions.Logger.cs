using Serilog;

namespace Ace.Geograpi.Web.Extensions;

public static partial class ApplicationBuilderExtensions
{
    public static void UseGeograpiLogger(this IApplicationBuilder app)
    {
        app.UseSerilogRequestLogging();
    }
}

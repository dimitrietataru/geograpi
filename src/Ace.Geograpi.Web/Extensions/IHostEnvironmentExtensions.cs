namespace Ace.Geograpi.Web.Extensions;

internal static class IHostEnvironmentExtensions
{
    public static bool IsDocker(this IHostEnvironment env)
    {
        return env.IsEnvironment("Docker");
    }
}

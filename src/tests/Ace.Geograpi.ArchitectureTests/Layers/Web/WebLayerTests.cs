using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.Domain;

namespace Ace.Geograpi.ArchitectureTests.Layers.Web;

public sealed class WebLayerTests : ArchUnitNetBase
{
    private readonly IReadOnlyCollection<string?> allowedExceptions = [
        typeof(Geograpi.Web.IWebMarker).FullName,
        typeof(Geograpi.Web.Program).FullName, "Program",
        typeof(Geograpi.Web.AppConfiguration).FullName,
        typeof(Geograpi.Web.ExceptionHandlers.DataNotFoundExceptionHandler).FullName,
        typeof(Geograpi.Web.ExceptionHandlers.GlobalExceptionHandler).FullName,
        typeof(Geograpi.Web.Extensions.IHostEnvironmentExtensions).FullName,
        typeof(Geograpi.Web.Extensions.Logging.LoggerExtensions).FullName
    ];

    [Fact]
    internal void WebTypesShouldBeCoveredByArchitectureRules()
    {
        // Arrange
        var typesWithNoRules = webTypes.GetObjects(architecture)
            .Except(webControllers.GetObjects(architecture))
            .Where(type => !allowedExceptions.Contains(type.FullName))
            .OfType<IType>()
            .ToList();

        // Assert
        typesWithNoRules.Should().BeEmpty(because: $"Web types should be covered by architecture rules: {string.Join(", ", typesWithNoRules.Select(t => t.FullName))}");
    }
}

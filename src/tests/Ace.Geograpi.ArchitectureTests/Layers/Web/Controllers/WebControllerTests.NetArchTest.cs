using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Web.Controllers;

public sealed class WebControllerNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void WebControllersShouldMatchNamespace()
    {
        // Arrange
        var rule = webControllers.Should().ResideInNamespaceMatching(NamespacePatterns.WebControllers);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void WebControllersShouldHaveControllerPostfix()
    {
        // Arrange
        var rule = webControllers.Should().HaveNameEndingWith("Controller", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void WebControllersShouldBePublic()
    {
        // Arrange
        var rule = webControllers.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void WebControllersShouldBeSealed()
    {
        // Arrange
        var rule = webControllers.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}

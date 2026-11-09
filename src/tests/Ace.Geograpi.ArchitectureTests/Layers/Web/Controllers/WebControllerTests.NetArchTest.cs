using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Web.Controllers;

public sealed class WebControllerNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void WebControllersShouldBeDefined()
    {
        // Arrange / Act
        var types = webControllers.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void WebControllersShouldMatchNamespace()
    {
        // Arrange
        var rule = webControllers.Should().ResideInNamespaceMatching(NamespacePatterns.WebControllers);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void WebControllersShouldHaveControllerSuffix()
    {
        // Arrange
        var rule = webControllers.Should().HaveNameEndingWith("Controller", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void WebControllersShouldBePublic()
    {
        // Arrange
        var rule = webControllers.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void WebControllersShouldBeSealed()
    {
        // Arrange
        var rule = webControllers.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void WebControllersShouldHaveAttributeApiController()
    {
        // Arrange
        var rule = webControllers.Should().HaveCustomAttribute(typeof(ApiControllerAttribute));

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void WebControllersShouldHaveAttributeApiVersion()
    {
        // Arrange
        var rule = webControllers.Should().HaveCustomAttribute(typeof(ApiVersionAttribute));

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void WebControllersShouldHaveAttributeRoute()
    {
        // Arrange
        var rule = webControllers.Should().HaveCustomAttribute(typeof(RouteAttribute));

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void WebControllersShouldHaveAttributeProduces()
    {
        // Arrange
        var rule = webControllers.Should().HaveCustomAttribute(typeof(ProducesAttribute));

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}

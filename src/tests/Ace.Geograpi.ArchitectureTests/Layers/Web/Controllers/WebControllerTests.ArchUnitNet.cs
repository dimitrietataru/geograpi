using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnitV3;

namespace Ace.Geograpi.ArchitectureTests.Layers.Web.Controllers;

public sealed class WebControllerArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void WebControllersShouldBeDefined()
    {
        // Arrange / Act
        var types = webControllers.GetObjects(architecture);

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void WebControllersShouldMatchNamespace()
    {
        // Arrange
        var rule = webControllers.Should().ResideInNamespaceMatching(NamespacePatterns.WebControllers);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void WebControllersShouldHaveControllerSuffix()
    {
        // Arrange
        var rule = webControllers.Should().HaveNameEndingWith("Controller");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void WebControllersShouldBePublic()
    {
        // Arrange
        var rule = webControllers.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void WebControllersShouldBeSealed()
    {
        // Arrange
        var rule = webControllers.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void WebControllersShouldHaveAttributeApiController()
    {
        // Arrange
        var rule = webControllers.Should().HaveAnyAttributes(typeof(ApiControllerAttribute));

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void WebControllersShouldHaveAttributeApiVersion()
    {
        // Arrange
        var rule = webControllers.Should().HaveAnyAttributes(typeof(ApiVersionAttribute));

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void WebControllersShouldHaveAttributeRoute()
    {
        // Arrange
        var rule = webControllers.Should().HaveAnyAttributes(typeof(RouteAttribute));

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void WebControllersShouldHaveAttributeProduces()
    {
        // Arrange
        var rule = webControllers.Should().HaveAnyAttributes(typeof(ProducesAttribute));

        // Act / Assert
        rule.Check(architecture);
    }
}

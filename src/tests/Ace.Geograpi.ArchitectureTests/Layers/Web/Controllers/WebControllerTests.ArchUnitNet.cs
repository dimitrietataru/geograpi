using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Web.Controllers;

public sealed class WebControllerArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void WebControllersShouldMatchNamespace()
    {
        // Arrange
        var rule = webControllers.Should().ResideInNamespaceMatching(NamespacePatterns.WebControllers);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void WebControllersShouldHaveControllerPostfix()
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
}

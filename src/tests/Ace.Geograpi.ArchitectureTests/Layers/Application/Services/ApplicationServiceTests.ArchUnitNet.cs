using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Application.Services;

public sealed class ApplicationServiceArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void ApplicationServicesShouldMatchNamespace()
    {
        // Arrange
        var rule = applicationServices.Should().ResideInNamespaceMatching(NamespacePatterns.ApplicationServices);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void ApplicationServicesShouldHaveServicePostfix()
    {
        // Arrange
        var rule = applicationServices.Should().HaveNameEndingWith("Service");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void ApplicationServicesShouldBePublic()
    {
        // Arrange
        var rule = applicationServices.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void ApplicationServicesShouldBeSealed()
    {
        // Arrange
        var rule = applicationServices.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}

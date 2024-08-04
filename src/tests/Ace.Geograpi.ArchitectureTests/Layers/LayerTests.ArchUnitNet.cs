using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers;

public sealed class LayerArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void DomainShouldNotHaveDependencyOnApplication()
    {
        // Arrange
        var rule = domainTypes.Should().NotDependOnAny(applicationLayer);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainShouldNotHaveDependencyOnInfrastructure()
    {
        // Arrange
        var rule = domainTypes.Should().NotDependOnAny(infrastructureLayer);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = domainTypes.Should().NotDependOnAny(webLayer);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void ApplicationShouldNotHaveDependencyOnInfrastructure()
    {
        // Arrange
        var rule = applicationTypes.Should().NotDependOnAny(infrastructureLayer);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void ApplicationShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = applicationTypes.Should().NotDependOnAny(webLayer);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureShouldNotHaveDependencyOnApplication()
    {
        // Arrange
        var rule = infrastructureTypes.Should().NotDependOnAny(applicationLayer);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureShouldNotHaveDependencyOnWeb()
    {
        // Arrange
        var rule = infrastructureTypes.Should().NotDependOnAny(webLayer);

        // Act / Assert
        rule.Check(architecture);
    }
}

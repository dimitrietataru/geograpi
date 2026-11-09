using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnitV3;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Data.Configurations;

public sealed class InfrastructureConfigurationArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void InfrastructureConfigurationsShouldBeDefined()
    {
        // Arrange / Act
        var types = infrastructureDataConfigurations.GetObjects(architecture);

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void InfrastructureConfigurationsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureDataConfigurations);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConfigurationsShouldHaveConfigurationSuffix()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().HaveNameEndingWith("Configuration");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConfigurationsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().BeInternal();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConfigurationsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}

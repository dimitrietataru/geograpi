using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Data.Configurations;

public sealed class InfrastructureConfigurationArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void InfrastructureConfigurationsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureDataConfigurations);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureConfigurationsShouldHaveConfigurationPostfix()
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

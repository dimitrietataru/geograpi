using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Data.Configurations;

public sealed class InfrastructureConfigurationNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void InfrastructureConfigurationsShouldBeDefined()
    {
        // Arrange / Act
        var types = infrastructureDataConfigurations.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void InfrastructureConfigurationsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureDataConfigurations);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureConfigurationsShouldHaveConfigurationSuffix()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().HaveNameEndingWith("Configuration", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureConfigurationsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureConfigurationsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureDataConfigurations.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}

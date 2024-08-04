using Ace.Geograpi.ArchitectureTests.Abstractions;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Data.Entities;

public sealed class InfrastructureEntityNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void InfrastructureEntitiesShouldHaveEntityPostfix()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().HaveNameEndingWith("Entity", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureEntitiesShouldBePublic()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void InfrastructureEntitiesShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}

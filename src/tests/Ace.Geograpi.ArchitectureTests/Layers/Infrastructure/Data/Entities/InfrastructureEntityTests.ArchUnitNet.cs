using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Data.Entities;

public sealed class InfrastructureEntityArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void InfrastructureEntitiesShouldHaveEntityPostfix()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().HaveNameEndingWith("Entity");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureEntitiesShouldBePublic()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureEntitiesShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}

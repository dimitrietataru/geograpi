using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Data.Entities;

public sealed class InfrastructureEntityArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void InfrastructureEntitiesShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureDataEntities);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureEntitiesShouldHaveEntityPostfix()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().HaveNameEndingWith("Entity");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureEntitiesShouldBePublic()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureEntitiesShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureDataEntities.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}

using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.Mappers;

public sealed class InfrastructureMapperArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void InfrastructureMappersShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureMappers.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureMappers);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureMappersShouldHaveMappingProfilePostfix()
    {
        // Arrange
        var rule = infrastructureMappers.Should().HaveNameEndingWith("MappingProfile");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureMappersShouldBePublic()
    {
        // Arrange
        var rule = infrastructureMappers.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureMappersShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureMappers.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}

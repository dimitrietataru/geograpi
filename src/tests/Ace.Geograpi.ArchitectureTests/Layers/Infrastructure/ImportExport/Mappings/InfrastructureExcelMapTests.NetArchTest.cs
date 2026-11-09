using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.ImportExport.Mappings;

public sealed class InfrastructureExcelMapNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void InfrastructureExcelMapsShouldBeDefined()
    {
        // Arrange / Act
        var types = infrastructureExcelMaps.GetTypes();

        // Assert
        types.Should().NotBeEmpty();
    }

    [Fact]
    internal void InfrastructureExcelMapsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureExcelMaps.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureExcelMaps);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureExcelMapsShouldHaveExcelMapSuffix()
    {
        // Arrange
        var rule = infrastructureExcelMaps.Should().HaveNameEndingWith("ExcelMap", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureExcelMapsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureExcelMaps.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }

    [Fact]
    internal void InfrastructureExcelMapsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureExcelMaps.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.ShouldBeSuccessful();
    }
}

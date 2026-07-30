using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.ImportExport.Mappings;

public sealed class InfrastructureExcelMapArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void InfrastructureExcelMapsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureExcelMaps.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureExcelMaps);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureExcelMapsShouldHaveMappingProfilePostfix()
    {
        // Arrange
        var rule = infrastructureExcelMaps.Should().HaveNameEndingWith("ExcelMap");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureExcelMapsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureExcelMaps.Should().BeInternal();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void InfrastructureExcelMapsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureExcelMaps.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}

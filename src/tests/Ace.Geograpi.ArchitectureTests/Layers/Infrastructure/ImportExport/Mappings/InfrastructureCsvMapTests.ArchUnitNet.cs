using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.ImportExport.Mappings;

public sealed class InfrastructureCsvMapArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void InfrastructureCsvMapsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureCsvMaps.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureCsvMaps);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureCsvMapsShouldHaveMappingProfilePostfix()
    {
        // Arrange
        var rule = infrastructureCsvMaps.Should().HaveNameEndingWith("CsvMap");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureCsvMapsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureCsvMaps.Should().BeInternal();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void InfrastructureCsvMapsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureCsvMaps.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}

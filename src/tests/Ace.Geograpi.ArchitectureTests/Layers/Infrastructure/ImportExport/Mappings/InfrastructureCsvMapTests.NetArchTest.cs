using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Infrastructure.ImportExport.Mappings;

public sealed class InfrastructureCsvMapNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void InfrastructureCsvMapsShouldMatchNamespace()
    {
        // Arrange
        var rule = infrastructureCsvMaps.Should().ResideInNamespaceMatching(NamespacePatterns.InfrastructureCsvMaps);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void InfrastructureCsvMapsShouldHaveMappingProfilePostfix()
    {
        // Arrange
        var rule = infrastructureCsvMaps.Should().HaveNameEndingWith("CsvMap", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void InfrastructureCsvMapsShouldBeInternal()
    {
        // Arrange
        var rule = infrastructureCsvMaps.Should().NotBePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void InfrastructureCsvMapsShouldBeSealed()
    {
        // Arrange
        var rule = infrastructureCsvMaps.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}

using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain;

public sealed class DomainModelArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal static void DomainModelsShouldHaveModelPostfix()
    {
        // Arrange
        var rule = domainModels.Should().HaveNameEndingWith("Model");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainModelsShouldBePublic()
    {
        // Arrange
        var rule = domainModels.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal static void DomainModelsShouldBeSealed()
    {
        // Arrange
        var rule = domainModels.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}

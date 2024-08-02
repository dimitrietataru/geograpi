using Ace.Geograpi.ArchitectureTests.Abstractions;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Domain;

public sealed class DomainModelArchUnitTests : ArchUnitNetBase
{
    [Fact]
    public static void DomainModelsShouldHaveModelPostfix()
    {
        // Arrange
        var rule = domainModels.Should().HaveNameEndingWith("Model");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    public static void DomainModelsShouldBePublic()
    {
        // Arrange
        var rule = domainModels.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    public static void DomainModelsShouldBeSealed()
    {
        // Arrange
        var rule = domainModels.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }
}

using Ace.Geograpi.ArchitectureTests.Abstractions;

namespace Ace.Geograpi.ArchitectureTests.Domain;

public sealed class DomainModelNetArchTestTests : NetArchTestBase
{
    [Fact]
    public static void DomainModelsShouldHaveModelPostfix()
    {
        // Arrange
        var rule = domainModels.Should().HaveNameEndingWith("Model", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public static void DomainModelsShouldBePublic()
    {
        // Arrange
        var rule = domainModels.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public static void DomainModelsShouldBeSealed()
    {
        // Arrange
        var rule = domainModels.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}

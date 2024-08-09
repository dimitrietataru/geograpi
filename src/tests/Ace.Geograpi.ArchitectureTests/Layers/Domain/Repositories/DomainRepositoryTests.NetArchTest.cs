using Ace.Geograpi.ArchitectureTests.Abstractions;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.Repositories;

public sealed class DomainRepositoryNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal static void DomainRepositoriesShouldHaveISuffix()
    {
        // Arrange
        var rule = domainRepositories.Should().HaveNameStartingWith("I", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainRepositoriesShouldHaveRepositoryPostfix()
    {
        // Arrange
        var rule = domainRepositories.Should().HaveNameEndingWith("Repository", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal static void DomainRepositoriesShouldBePublic()
    {
        // Arrange
        var rule = domainRepositories.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }
}

using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.ImportExport.Dtos;

public sealed class DomainExchangeDtoNetArchTestTests : NetArchTestBase
{
    [Fact]
    internal void DomainExchangeDtosShouldMatchNamespace()
    {
        // Arrange
        var rule = domainExchangeDtos.Should().ResideInNamespaceMatching(NamespacePatterns.DomainExchangeDtos);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainExchangeDtosShouldHaveModelPostfix()
    {
        // Arrange
        var rule = domainExchangeDtos.Should().HaveNameEndingWith("ExchangeDto", StringComparison.Ordinal);

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainExchangeDtosShouldBePublic()
    {
        // Arrange
        var rule = domainExchangeDtos.Should().BePublic();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainExchangeDtosShouldBeSealed()
    {
        // Arrange
        var rule = domainExchangeDtos.Should().BeSealed();

        // Act
        var result = rule.GetResult();

        // Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    internal void DomainExchangeDtosShouldHavePublicGettersAndSetters()
    {
        // Arrange
        var types = domainExchangeDtos.GetTypes();

        // Act / Assert
        foreach (var type in types)
        {
            foreach (var property in type.GetProperties())
            {
                var getter = property.GetMethod.Should().NotBeNull().And.BeAssignableTo<MethodInfo>().Subject;
                getter!.IsPublic.Should().BeTrue();

                var setter = property.SetMethod.Should().NotBeNull().And.BeAssignableTo<MethodInfo>().Subject;
                setter!.IsPublic.Should().BeTrue();

                var setterModifiers = setter!.ReturnParameter.GetRequiredCustomModifiers();
                setterModifiers.Should().NotContain(typeof(IsExternalInit), because: "Setters should be declared as 'set', not 'init'");
            }
        }
    }
}

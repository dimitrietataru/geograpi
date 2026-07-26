using Ace.Geograpi.ArchitectureTests.Abstractions;
using Ace.Geograpi.ArchitectureTests.Symbols;
using ArchUnitNET.xUnit;

namespace Ace.Geograpi.ArchitectureTests.Layers.Domain.ImportExport.Dtos;

public sealed class DomainExchangeDtoArchUnitNetTests : ArchUnitNetBase
{
    [Fact]
    internal void DomainExchangeDtosShouldMatchNamespace()
    {
        // Arrange
        var rule = domainExchangeDtos.Should().ResideInNamespaceMatching(NamespacePatterns.DomainExchangeDtos);

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainExchangeDtosShouldHaveModelPostfix()
    {
        // Arrange
        var rule = domainExchangeDtos.Should().HaveNameEndingWith("ExchangeDto");

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainExchangeDtosShouldBePublic()
    {
        // Arrange
        var rule = domainExchangeDtos.Should().BePublic();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainExchangeDtosShouldBeSealed()
    {
        // Arrange
        var rule = domainExchangeDtos.Should().BeSealed();

        // Act / Assert
        rule.Check(architecture);
    }

    [Fact]
    internal void DomainExchangeDtosShouldHavePublicGettersAndSetters()
    {
        // Arrange
        var types = domainExchangeDtos
            .GetObjects(architecture)
            .Select(t => domainAssembly.GetType(t.FullName))
            .OfType<Type>()
            .ToList();

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

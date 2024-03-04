using Ace.CSharp.DataFaker;
using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.IntegrationTests.Fakers.Extensions;
using Bogus;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;

internal sealed class FakeEntity : AbstractDataFaker<FakeEntity>
{
    private Faker<ContinentEntity> FakeContinentEntity =>
        new Faker<ContinentEntity>(locale: LocaleCode)
            .ConfigureEntityId()
            .ConfigureTraceableEntity()
            .RuleFor(
                continent => continent.Name,
                f => f.Random.String2(length: 10))
            .RuleFor(
                continent => continent.Countries,
                _ => FakeCountryEntity.GenerateBetween(1, 3))
            .StrictMode(ensureRulesForAllProperties: false);

    private Faker<CountryEntity> FakeCountryEntity =>
        new Faker<CountryEntity>(locale: LocaleCode)
            .ConfigureEntityId()
            .ConfigureTraceableEntity()
            .RuleFor(
                country => country.ContinentId,
                f => f.Random.Int(min: 1))
            .RuleFor(
                country => country.Name,
                f => f.Random.String2(length: 10))
            .RuleFor(
                country => country.Continent,
                _ => default!)
            .StrictMode(ensureRulesForAllProperties: false);
}

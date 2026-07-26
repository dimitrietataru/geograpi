using Ace.CSharp.DataFaker;
using Ace.Geograpi.Domain.ImportExport.Dtos;
using Bogus;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;

public sealed class FakeExchange : AbstractDataFaker<FakeExchange>
{
    private Faker<ContinentExchangeDto> FakeContinentExchangeDto =>
        new Faker<ContinentExchangeDto>(locale: LocaleCode)
            .RuleFor(
                dto => dto.Name,
                f => f.Random.String2(length: 10))
            .StrictMode(ensureRulesForAllProperties: true);

    private Faker<CountryExchangeDto> FakeCountryExchangeDto =>
        new Faker<CountryExchangeDto>(locale: LocaleCode)
            .RuleFor(
                dto => dto.ContinentName,
                f => f.Random.String2(length: 10))
            .RuleFor(
                dto => dto.Name,
                f => f.Random.String2(length: 10))
            .StrictMode(ensureRulesForAllProperties: true);
}

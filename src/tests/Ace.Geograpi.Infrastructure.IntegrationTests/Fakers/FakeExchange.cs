using Ace.CSharp.DataFaker;
using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Symbols.Data;
using Bogus;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;

public sealed class FakeExchange : AbstractDataFaker<FakeExchange>
{
    private Faker<ContinentExchangeDto> FakeContinentExchangeDto =>
        new Faker<ContinentExchangeDto>(locale: LocaleCode)
            .RuleFor(
                dto => dto.RowNumber,
                f => f.Random.Int(min: 1, max: 100))
            .RuleFor(
                dto => dto.Code,
                f => f.PickRandom(
                    ContinentCode.Africa,
                    ContinentCode.Antarctica,
                    ContinentCode.Asia,
                    ContinentCode.Europe,
                    ContinentCode.Oceania,
                    ContinentCode.NorthAmerica,
                    ContinentCode.SouthAmerica))
            .RuleFor(
                dto => dto.Name,
                f => f.PickRandom(
                    ContinentName.Africa,
                    ContinentName.Antarctica,
                    ContinentName.Asia,
                    ContinentName.Europe,
                    ContinentName.Oceania,
                    ContinentName.NorthAmerica,
                    ContinentName.SouthAmerica))
            .StrictMode(ensureRulesForAllProperties: true);

    private Faker<CountryExchangeDto> FakeCountryExchangeDto =>
        new Faker<CountryExchangeDto>(locale: LocaleCode)
            .RuleFor(
                dto => dto.RowNumber,
                f => f.Random.Int(min: 1, max: 100))
            .RuleFor(
                dto => dto.ContinentName,
                f => f.Random.String2(length: 10))
            .RuleFor(
                dto => dto.Name,
                f => f.Random.String2(length: 10))
            .StrictMode(ensureRulesForAllProperties: true);
}

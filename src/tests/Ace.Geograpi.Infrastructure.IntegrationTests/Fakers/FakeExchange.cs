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
            .RuleFor(
                dto => dto.GoogleId,
                f => f.Random.String2(length: 32))
            .RuleFor(
                dto => dto.BoundaryN,
                f => f.Random.Decimal(min: -90, max: 90))
            .RuleFor(
                dto => dto.BoundaryS,
                f => f.Random.Decimal(min: -90, max: 90))
            .RuleFor(
                dto => dto.BoundaryE,
                f => f.Random.Decimal(min: -180, max: 180))
            .RuleFor(
                dto => dto.BoundaryW,
                f => f.Random.Decimal(min: -180, max: 180))
            .RuleFor(
                dto => dto.CenterLat,
                f => f.Random.Decimal(min: -90, max: 90))
            .RuleFor(
                dto => dto.CenterLng,
                f => f.Random.Decimal(min: -180, max: 180))
            .StrictMode(ensureRulesForAllProperties: true);

    private Faker<CountryExchangeDto> FakeCountryExchangeDto =>
        new Faker<CountryExchangeDto>(locale: LocaleCode)
            .RuleFor(
                dto => dto.RowNumber,
                f => f.Random.Int(min: 1, max: 100))
            .RuleFor(
                dto => dto.ContinentCode,
                f => f.PickRandom(
                    ContinentCode.Africa,
                    ContinentCode.Antarctica,
                    ContinentCode.Asia,
                    ContinentCode.Europe,
                    ContinentCode.Oceania,
                    ContinentCode.NorthAmerica,
                    ContinentCode.SouthAmerica))
            .RuleFor(
                dto => dto.Code,
                f => f.Random.String2(length: 2))
            .RuleFor(
                dto => dto.CodeA3,
                f => f.Random.String2(length: 3))
            .RuleFor(
                dto => dto.Name,
                f => f.Random.String2(length: 10))
            .RuleFor(
                dto => dto.NameOfficial,
                f => f.Random.String2(length: 20))
            .RuleFor(
                dto => dto.Area,
                f => Math.Round(f.Random.Double(min: 1, max: 1_000_000), 2))
            .RuleFor(
                dto => dto.Population,
                f => f.Random.Int(min: 10_000, max: 1_000_000_000))
            .RuleFor(
                dto => dto.GoogleId,
                f => f.Random.String2(length: 32))
            .RuleFor(
                dto => dto.BoundaryN,
                f => f.Random.Decimal(min: -90, max: 90))
            .RuleFor(
                dto => dto.BoundaryS,
                f => f.Random.Decimal(min: -90, max: 90))
            .RuleFor(
                dto => dto.BoundaryE,
                f => f.Random.Decimal(min: -180, max: 180))
            .RuleFor(
                dto => dto.BoundaryW,
                f => f.Random.Decimal(min: -180, max: 180))
            .RuleFor(
                dto => dto.CenterLat,
                f => f.Random.Decimal(min: -90, max: 90))
            .RuleFor(
                dto => dto.CenterLng,
                f => f.Random.Decimal(min: -180, max: 180))
            .StrictMode(ensureRulesForAllProperties: true);
}

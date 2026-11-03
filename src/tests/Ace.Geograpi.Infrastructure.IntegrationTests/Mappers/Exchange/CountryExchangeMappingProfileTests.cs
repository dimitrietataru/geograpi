using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;
using Ace.Geograpi.Infrastructure.Mappers.Exchange;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Mappers.Exchange;

public sealed class CountryExchangeMappingProfileTests
    : BaseOneWayProfileTests<CountryExchangeMappingProfile, CountryExchangeDto, CountryEntity>
{
    private readonly FakeExchange fakeExchange = new();

    protected sealed override Func<CountryExchangeDto> Left => fakeExchange.Of<CountryExchangeDto>;

    protected sealed override Action<CountryExchangeDto, CountryEntity>? LeftToRightAssertions =>
        (dto, entity) =>
        {
            entity.Id.Should().Be(default);
            entity.Code.Should().Be(dto.Code);
            entity.CodeA3.Should().Be(dto.CodeA3);
            entity.Name.Should().Be(dto.Name);
            entity.NameOfficial.Should().Be(dto.NameOfficial);
            entity.Area.Should().Be(dto.Area);
            entity.Population.Should().Be(dto.Population);
            entity.GoogleId.Should().Be(dto.GoogleId);
            entity.BoundaryN.Should().Be(dto.BoundaryN);
            entity.BoundaryS.Should().Be(dto.BoundaryS);
            entity.BoundaryE.Should().Be(dto.BoundaryE);
            entity.BoundaryW.Should().Be(dto.BoundaryW);
            entity.CenterLat.Should().Be(dto.CenterLat);
            entity.CenterLng.Should().Be(dto.CenterLng);
        };

    protected sealed override IEnumerable<Type> RelatedMappingProfiles => [];

    [Fact]
    public sealed override void GivenMapFromLeftToRightWhenSourceIsNullThenHandlesGracefully()
    {
        base.GivenMapFromLeftToRightWhenSourceIsNullThenHandlesGracefully();
    }

    [Fact]
    public sealed override void GivenMapFromLeftToRightWhenSourceIsNotNullThenMapsData()
    {
        base.GivenMapFromLeftToRightWhenSourceIsNotNullThenMapsData();
    }

    [Fact]
    public sealed override void GivenMapFromRightToLeftWhenMappingIsNotConfiguredThenThrowsException()
    {
        base.GivenMapFromRightToLeftWhenMappingIsNotConfiguredThenThrowsException();
    }
}

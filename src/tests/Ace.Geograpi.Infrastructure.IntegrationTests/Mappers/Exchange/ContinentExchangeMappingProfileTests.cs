using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;
using Ace.Geograpi.Infrastructure.Mappers.Exchange;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Mappers.Exchange;

public sealed class ContinentExchangeMappingProfileTests
    : BaseOneWayProfileTests<ContinentExchangeMappingProfile, ContinentExchangeDto, ContinentEntity>
{
    private readonly FakeExchange fakeExchange = new();

    protected sealed override Func<ContinentExchangeDto> Left => fakeExchange.Of<ContinentExchangeDto>;

    protected sealed override Action<ContinentExchangeDto, ContinentEntity>? LeftToRightAssertions =>
        (dto, entity) =>
        {
            entity.Id.Should().Be(default);
            entity.Code.Should().Be(dto.Code);
            entity.Name.Should().Be(dto.Name);
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

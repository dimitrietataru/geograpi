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
            entity.Name.Should().Be(dto.Name);
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

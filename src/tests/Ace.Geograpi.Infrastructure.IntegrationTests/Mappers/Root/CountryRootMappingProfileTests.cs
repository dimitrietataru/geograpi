using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;
using Ace.Geograpi.Infrastructure.Mappers.Root;
using Ace.Geograpi.Infrastructure.Mappers.Traceable;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Mappers.Root;

public sealed class CountryRootMappingProfileTests
    : BaseOneWayProfileTests<CountryRootMappingProfile, CountryEntity, CountryRootModel>
{
    private readonly FakeEntity fakeEntity = new();

    protected sealed override Func<CountryEntity> Left => fakeEntity.Of<CountryEntity>;

    protected sealed override Action<CountryEntity, CountryRootModel>? LeftToRightAssertions =>
        (entity, model) =>
        {
            model.Id.Should().Be(entity.Id);
            model.ContinentId.Should().Be(entity.ContinentId);
            model.Name.Should().Be(entity.Name);
        };

    protected sealed override IEnumerable<Type> RelatedtMappingProfiles =>
        [typeof(ModelIntMappingProfile)];

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
}

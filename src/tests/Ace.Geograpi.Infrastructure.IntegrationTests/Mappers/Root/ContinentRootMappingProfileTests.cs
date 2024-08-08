using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;
using Ace.Geograpi.Infrastructure.Mappers.Root;
using Ace.Geograpi.Infrastructure.Mappers.Traceable;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Mappers.Root;

public sealed class ContinentRootMappingProfileTests
    : BaseOneWayProfileTests<ContinentRootMappingProfile, ContinentEntity, ContinentRootModel>
{
    private readonly FakeEntity fakeEntity = new();

    protected sealed override Func<ContinentEntity> Left => fakeEntity.Of<ContinentEntity>;

    protected sealed override Action<ContinentEntity, ContinentRootModel>? LeftToRightAssertions =>
        (entity, model) =>
        {
            model.Id.Should().Be(entity.Id);
            model.Name.Should().Be(entity.Name);
        };

    protected sealed override IEnumerable<Type> RelatedMappingProfiles =>
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

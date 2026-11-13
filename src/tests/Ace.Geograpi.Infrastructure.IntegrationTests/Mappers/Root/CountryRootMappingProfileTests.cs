using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;
using Ace.Geograpi.Infrastructure.Mappers.Base;
using Ace.Geograpi.Infrastructure.Mappers.Root;

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
            model.Code.Should().Be(entity.Code);
            model.CodeA3.Should().Be(entity.CodeA3);
            model.Name.Should().Be(entity.Name);
            model.NameOfficial.Should().Be(entity.NameOfficial);
            model.Area.Should().Be(entity.Area);
            model.Population.Should().Be(entity.Population);
            model.GoogleId.Should().Be(entity.GoogleId);
            model.BoundaryN.Should().Be(entity.BoundaryN);
            model.BoundaryS.Should().Be(entity.BoundaryS);
            model.BoundaryE.Should().Be(entity.BoundaryE);
            model.BoundaryW.Should().Be(entity.BoundaryW);
            model.CenterLat.Should().Be(entity.CenterLat);
            model.CenterLng.Should().Be(entity.CenterLng);
        };

    protected sealed override IEnumerable<Type> RelatedMappingProfiles =>
        [typeof(CrudMappingProfile)];

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

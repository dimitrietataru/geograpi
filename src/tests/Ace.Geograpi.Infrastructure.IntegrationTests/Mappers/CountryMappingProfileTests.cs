using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;
using Ace.Geograpi.Infrastructure.Mappers;
using Ace.Geograpi.Infrastructure.Mappers.Traceable;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Mappers;

public sealed class CountryMappingProfileTests
    : BaseTwoWayProfileTests<CountryMappingProfile, CountryEntity, CountryModel>
{
    private readonly FakeEntity fakeEntity = new();
    private readonly FakeModel fakeModel = new();

    protected sealed override Func<CountryEntity> Left => fakeEntity.Of<CountryEntity>;
    protected sealed override Func<CountryModel> Right => fakeModel.Of<CountryModel>;

    protected sealed override Action<CountryEntity, CountryModel>? LeftToRightAssertions =>
        (entity, model) =>
        {
            model.Id.Should().Be(entity.Id);
            model.ContinentId.Should().Be(entity.ContinentId);
            model.Name.Should().Be(entity.Name);

            model.CreatedAt.Should().Be(entity.CreatedAt);
            model.CreatedBy.Should().Be(entity.CreatedBy);
            model.UpdatedAt.Should().Be(entity.UpdatedAt);
            model.UpdatedBy.Should().Be(entity.UpdatedBy);
            model.IsDeleted.Should().Be(entity.IsDeleted);
            model.DeletedAt.Should().Be(entity.DeletedAt);
            model.DeletedBy.Should().Be(entity.DeletedBy);
        };

    protected sealed override Action<CountryModel, CountryEntity>? RightToLeftAssertions =>
        (model, entity) =>
        {
            entity.Id.Should().Be(default, because: "Id is ignored");
            entity.ContinentId.Should().Be(model.ContinentId);
            entity.Name.Should().Be(model.Name);
            entity.Continent.Should().BeNull();

            entity.CreatedAt.Should().BeNull();
            entity.CreatedBy.Should().Be(default);
            entity.UpdatedAt.Should().BeNull();
            entity.UpdatedBy.Should().Be(default);
            entity.IsDeleted.Should().BeFalse();
            entity.DeletedAt.Should().BeNull();
            entity.DeletedBy.Should().Be(default);
        };

    protected sealed override IEnumerable<Type> RelatedMappingProfiles =>
        new List<Type> { typeof(TraceableIntMapper) };

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
    public sealed override void GivenMapFromRightToLeftWhenSourceIsNullThenHandlesGracefully()
    {
        base.GivenMapFromRightToLeftWhenSourceIsNullThenHandlesGracefully();
    }

    [Fact]
    public sealed override void GivenMapFromRightToLeftWhenSourceIsNotNullThenMapsData()
    {
        base.GivenMapFromRightToLeftWhenSourceIsNotNullThenMapsData();
    }
}

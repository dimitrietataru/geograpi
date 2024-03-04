using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Infrastructure.Data.Entities;
using Ace.Geograpi.Infrastructure.IntegrationTests.Fakers;
using Ace.Geograpi.Infrastructure.Mappers;
using Ace.Geograpi.Infrastructure.Mappers.Traceable;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Mappers;

public sealed class ContinentMappingProfileTests
    : BaseTwoWayProfileTests<ContinentMappingProfile, ContinentEntity, ContinentModel>
{
    private readonly FakeEntity fakeEntity = new();
    private readonly FakeModel fakeModel = new();

    protected sealed override Func<ContinentEntity> Left => fakeEntity.Of<ContinentEntity>;
    protected sealed override Func<ContinentModel> Right => fakeModel.Of<ContinentModel>;

    protected sealed override Action<ContinentEntity, ContinentModel>? LeftToRightAssertions =>
        (entity, model) =>
        {
            model.Id.Should().Be(entity.Id);
            model.Name.Should().Be(entity.Name);
            model.Countries.Should().NotBeNull().And.HaveSameCount(entity.Countries);

            model.CreatedAt.Should().Be(entity.CreatedAt);
            model.CreatedBy.Should().Be(entity.CreatedBy);
            model.UpdatedAt.Should().Be(entity.UpdatedAt);
            model.UpdatedBy.Should().Be(entity.UpdatedBy);
            model.IsDeleted.Should().Be(entity.IsDeleted);
            model.DeletedAt.Should().Be(entity.DeletedAt);
            model.DeletedBy.Should().Be(entity.DeletedBy);
        };

    protected sealed override Action<ContinentModel, ContinentEntity>? RightToLeftAssertions =>
        (model, entity) =>
        {
            entity.Id.Should().Be(default, because: "Id is ignored");
            entity.Name.Should().Be(model.Name);
            entity.Countries.Should().NotBeNull().And.HaveSameCount(model.Countries);

            entity.CreatedAt.Should().BeNull();
            entity.CreatedBy.Should().Be(default);
            entity.UpdatedAt.Should().BeNull();
            entity.UpdatedBy.Should().Be(default);
            entity.IsDeleted.Should().BeFalse();
            entity.DeletedAt.Should().BeNull();
            entity.DeletedBy.Should().Be(default);
        };

    protected sealed override IEnumerable<Type> RelatedMappingProfiles =>
        new List<Type> { typeof(CountryMappingProfile), typeof(TraceableIntMapper) };

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

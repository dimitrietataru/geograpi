using Ace.Geograpi.Infrastructure.Mappers;
using ContinentEntity = Ace.Geograpi.Infrastructure.Data.Entities.Continent;
using ContinentModel = Ace.Geograpi.Domain.Models.Continent;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Mappers;

public sealed class ContinentMappingProfileTests : BaseTwoWayProfileTests<ContinentMappingProfile, ContinentEntity, ContinentModel>
{
    protected sealed override Func<ContinentEntity> Left =>
        () =>
            new ContinentEntity
            {
                Id = 1,
                Name = "ContinentEntity",
                Countries = []
            };

    protected sealed override Func<ContinentModel> Right =>
        () =>
            new ContinentModel
            {
                Id = 2,
                Name = "ContinentModel",
                Countries = []
            };

    protected sealed override Action<ContinentEntity, ContinentModel>? LeftToRightAssertions =>
        (entity, model) =>
        {
            model.Id.Should().Be(entity.Id);
            model.Name.Should().Be(entity.Name);
            model.Countries.Should().NotBeNull().And.HaveSameCount(entity.Countries);
        };

    protected sealed override Action<ContinentModel, ContinentEntity>? RightToLeftAssertions =>
        (model, entity) =>
        {
            entity.Id.Should().Be(default, because: "Id is ignored");
            entity.Name.Should().Be(model.Name);
            entity.Countries.Should().NotBeNull().And.HaveSameCount(model.Countries);
        };

    [Fact]
    public override void GivenMapFromLeftToRightWhenSourceIsNullThenHandlesGracefully()
    {
        base.GivenMapFromLeftToRightWhenSourceIsNullThenHandlesGracefully();
    }

    [Fact]
    public override void GivenMapFromLeftToRightWhenSourceIsNotNullThenMapsData()
    {
        base.GivenMapFromLeftToRightWhenSourceIsNotNullThenMapsData();
    }

    [Fact]
    public override void GivenMapFromRightToLeftWhenSourceIsNullThenHandlesGracefully()
    {
        base.GivenMapFromRightToLeftWhenSourceIsNullThenHandlesGracefully();
    }

    [Fact]
    public override void GivenMapFromRightToLeftWhenSourceIsNotNullThenMapsData()
    {
        base.GivenMapFromRightToLeftWhenSourceIsNotNullThenMapsData();
    }
}

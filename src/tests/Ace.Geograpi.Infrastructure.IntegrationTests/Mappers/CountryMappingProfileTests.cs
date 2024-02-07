using Ace.Geograpi.Infrastructure.Mappers;
using CountryEntity = Ace.Geograpi.Infrastructure.Data.Entities.Country;
using CountryModel = Ace.Geograpi.Domain.Models.Country;

namespace Ace.Geograpi.Infrastructure.IntegrationTests.Mappers;

public sealed class CountryMappingProfileTests : BaseTwoWayProfileTests<CountryMappingProfile, CountryEntity, CountryModel>
{
    protected sealed override Func<CountryEntity> Left =>
        () =>
            new CountryEntity
            {
                Id = 1,
                ContinentId = 1,
                Name = "CountryEntity"
            };

    protected sealed override Func<CountryModel> Right =>
        () =>
            new CountryModel
            {
                Id = 2,
                ContinentId = 2,
                Name = "CountryModel"
            };

    protected sealed override Action<CountryEntity, CountryModel>? LeftToRightAssertions =>
        (entity, model) =>
        {
            model.Id.Should().Be(entity.Id);
            model.ContinentId.Should().Be(entity.ContinentId);
            model.Name.Should().Be(entity.Name);
        };

    protected sealed override Action<CountryModel, CountryEntity>? RightToLeftAssertions =>
        (model, entity) =>
        {
            entity.Id.Should().Be(default, because: "Id is ignored");
            entity.ContinentId.Should().Be(model.ContinentId);
            entity.Name.Should().Be(model.Name);
            entity.Continent.Should().BeNull();
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

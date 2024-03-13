using CatNip.Domain.Models.Interfaces;
using CatNip.Domain.Query.Filtering;
using CatNip.Domain.Services;
using CatNip.Presentation.Controllers;
using CatNip.Presentation.Test.Controllers;

namespace Ace.Geograpi.Web.Tests.Controllers.Abstractions;

public abstract class XUnitAceControllerTests<TController, TService, TModel, TId, TFiltering>
    : BaseAceControllerTests<TController, TService, TModel, TId, TFiltering>
    where TController : AceController<TService, TModel, TId, TFiltering>
    where TService : class, IAceService<TModel, TId, TFiltering>
    where TModel : IModel<TId>
    where TId : IEquatable<TId>
    where TFiltering : IFilteringRequest
{
    [Fact]
    public override async Task GivenFilterWhenDataExistsThenReturnsData()
    {
        await base.GivenFilterWhenDataExistsThenReturnsData();
    }

    [Fact]
    public override async Task GivenFilterCountWhenDataExistsThenReturnsCount()
    {
        await base.GivenFilterCountWhenDataExistsThenReturnsCount();
    }

    [Fact]
    public override async Task GivenGetAllWhenDataExistsThenReturnsData()
    {
        await base.GivenGetAllWhenDataExistsThenReturnsData();
    }

    [Fact]
    public override async Task GivenCountWhenDataExistsThenReturnsCount()
    {
        await base.GivenCountWhenDataExistsThenReturnsCount();
    }

    [Fact]
    public override async Task GivenGetByIdWhenDataExistsThenReturnsData()
    {
        await base.GivenGetByIdWhenDataExistsThenReturnsData();
    }

    [Fact]
    public override async Task GivenGetByIdWhenDataNotFoundThenThrowsException()
    {
        await base.GivenGetByIdWhenDataNotFoundThenThrowsException();
    }

    [Fact]
    public override async Task GivenCreateWhenInputIsValidThenCreatesData()
    {
        await base.GivenCreateWhenInputIsValidThenCreatesData();
    }

    [Fact]
    public override async Task GivenUpdateWhenDataExistsThenUpdatesData()
    {
        await base.GivenUpdateWhenDataExistsThenUpdatesData();
    }

    [Fact]
    public override async Task GivenUpdateWhenDataNotFoundThenThrowsException()
    {
        await base.GivenUpdateWhenDataNotFoundThenThrowsException();
    }

    [Fact]
    public override async Task GivenDeleteWhenDataExistsThenDeletesData()
    {
        await base.GivenDeleteWhenDataExistsThenDeletesData();
    }

    [Fact]
    public override async Task GivenDeleteWhenDataNotFoundThenThrowsException()
    {
        await base.GivenDeleteWhenDataNotFoundThenThrowsException();
    }
}

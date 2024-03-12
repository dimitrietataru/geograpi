using CatNip.Application.Services;
using CatNip.Application.Test.Services;
using CatNip.Domain.Models.Interfaces;
using CatNip.Domain.Query.Filtering;
using CatNip.Domain.Repositories;

namespace Ace.Geograpi.Application.Tests.Services.Abstractions;

public abstract class XUnitAceServiceTests<TService, TRepository, TModel, TId, TFiltering>
    : BaseAceServiceTests<TService, TRepository, TModel, TId, TFiltering>
    where TService : AceService<TRepository, TModel, TId, TFiltering>
    where TRepository : class, IAceRepository<TModel, TId, TFiltering>
    where TModel : IModel<TId>
    where TId : IEquatable<TId>
    where TFiltering : IFilteringRequest
{
    [Fact]
    public override async Task GivenGetFilteredWhenDataExistsThenReturnsData()
    {
        await base.GivenGetFilteredWhenDataExistsThenReturnsData();
    }

    [Fact]
    public override async Task GivenCountFilteredWhenDataExistsThenReturnsData()
    {
        await base.GivenCountFilteredWhenDataExistsThenReturnsData();
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
    public override async Task GivenExistsWhenDataExistsThenReturnsTrue()
    {
        await base.GivenExistsWhenDataExistsThenReturnsTrue();
    }

    [Fact]
    public override async Task GivenExistsWhenDataNotFoundThenReturnsFalse()
    {
        await base.GivenExistsWhenDataNotFoundThenReturnsFalse();
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

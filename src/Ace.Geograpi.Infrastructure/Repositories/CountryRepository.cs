using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Infrastructure.Data;
using Ace.Geograpi.Infrastructure.Data.Entities;
using CatNip.Domain.Query.Sorting;
using CatNip.Domain.Query.Sorting.Symbols;
using CatNip.Infrastructure.Repositories;
using Model = Ace.Geograpi.Domain.Models;

namespace Ace.Geograpi.Infrastructure.Repositories;

internal sealed class CountryRepository
    : AceRepository<GeograpiDbContext, Country, Model.Country, int, CountryQueryFilter>, ICountryRepository
{
    public CountryRepository(GeograpiDbContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    protected sealed override IQueryable<Country> BuildFilteringQuery(
        IQueryable<Country> query, CountryQueryFilter request)
    {
        if (request.Id != default)
        {
            query = query.Where(c => c.Id == request.Id);
        }

        if (request.Ids.Any())
        {
            query = query.Where(c => request.Ids.Contains(c.Id));
        }

        if (!string.IsNullOrWhiteSpace(request.Name))
        {
            query = query.Where(c => c.Name == request.Name);
        }

        return query;
    }

    protected sealed override IQueryable<Country> BuildSortingQuery(
        IQueryable<Country> query, ISortingRequest sortingRequest)
    {
        query = base.BuildSortingQuery(query, sortingRequest);

        return (sortingRequest.SortBy, sortingRequest.SortDirection) switch
        {
            (nameof(Country.Name), SortDirection.Ascending) => query.OrderBy(c => c.Name),
            (nameof(Country.Name), SortDirection.Descending) => query.OrderByDescending(c => c.Name),
            _ => query
        };
    }
}

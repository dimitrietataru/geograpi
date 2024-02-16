using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Infrastructure.Data;
using Ace.Geograpi.Infrastructure.Data.Entities;
using CatNip.Domain.Query.Sorting;
using CatNip.Domain.Query.Sorting.Symbols;
using CatNip.Infrastructure.Repositories;

namespace Ace.Geograpi.Infrastructure.Repositories;

internal sealed class CountryRepository
    : AceRepository<GeograpiDbContext, CountryEntity, CountryModel, int, CountryQueryFilter>, ICountryRepository
{
    public CountryRepository(GeograpiDbContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    protected sealed override IQueryable<CountryEntity> BuildIncludeQuery(
        IQueryable<CountryEntity> query)
    {
        return query.Include(c => c.Continent);
    }

    protected sealed override IQueryable<CountryEntity> BuildFilteringQuery(
        IQueryable<CountryEntity> query, CountryQueryFilter request)
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

    protected sealed override IQueryable<CountryEntity> BuildSortingQuery(
        IQueryable<CountryEntity> query, ISortingRequest sortingRequest)
    {
        query = base.BuildSortingQuery(query, sortingRequest);

        return (sortingRequest.SortBy, sortingRequest.SortDirection) switch
        {
            (nameof(CountryEntity.Name), SortDirection.Ascending) => query.OrderBy(c => c.Name),
            (nameof(CountryEntity.Name), SortDirection.Descending) => query.OrderByDescending(c => c.Name),
            _ => query
        };
    }
}

using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Infrastructure.Data;
using Ace.Geograpi.Infrastructure.Data.Entities;
using CatNip.Domain.Query.Sorting;
using CatNip.Domain.Query.Sorting.Symbols;
using CatNip.Infrastructure.Repositories;
using Model = Ace.Geograpi.Domain.Models;

namespace Ace.Geograpi.Infrastructure.Repositories;

internal sealed class ContinentRepository
    : AceRepository<GeograpiDbContext, Continent, Model.Continent, int, ContinentQueryFilter>, IContinentRepository
{
    public ContinentRepository(GeograpiDbContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    protected sealed override IQueryable<Continent> BuildFilteringQuery(
        IQueryable<Continent> query, ContinentQueryFilter request)
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

    protected sealed override IQueryable<Continent> BuildSortingQuery(
        IQueryable<Continent> query, ISortingRequest sortingRequest)
    {
        query = base.BuildSortingQuery(query, sortingRequest);

        return (sortingRequest.SortBy, sortingRequest.SortDirection) switch
        {
            (nameof(Continent.Name), SortDirection.Ascending) => query.OrderBy(c => c.Name),
            (nameof(Continent.Name), SortDirection.Descending) => query.OrderByDescending(c => c.Name),
            _ => query
        };
    }
}

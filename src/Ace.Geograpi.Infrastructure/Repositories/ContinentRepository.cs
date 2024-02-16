using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Infrastructure.Data;
using Ace.Geograpi.Infrastructure.Data.Entities;
using CatNip.Domain.Query.Sorting;
using CatNip.Domain.Query.Sorting.Symbols;
using CatNip.Infrastructure.Repositories;

namespace Ace.Geograpi.Infrastructure.Repositories;

internal sealed class ContinentRepository
    : AceRepository<GeograpiDbContext, ContinentEntity, ContinentModel, int, ContinentQueryFilter>, IContinentRepository
{
    public ContinentRepository(GeograpiDbContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    protected sealed override IQueryable<ContinentEntity> BuildIncludeQuery(
        IQueryable<ContinentEntity> query)
    {
        return query.Include(c => c.Countries);
    }

    protected sealed override IQueryable<ContinentEntity> BuildFilteringQuery(
        IQueryable<ContinentEntity> query, ContinentQueryFilter request)
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

    protected sealed override IQueryable<ContinentEntity> BuildSortingQuery(
        IQueryable<ContinentEntity> query, ISortingRequest sortingRequest)
    {
        query = base.BuildSortingQuery(query, sortingRequest);

        return (sortingRequest.SortBy, sortingRequest.SortDirection) switch
        {
            (nameof(ContinentEntity.Name), SortDirection.Ascending) => query.OrderBy(c => c.Name),
            (nameof(ContinentEntity.Name), SortDirection.Descending) => query.OrderByDescending(c => c.Name),
            _ => query
        };
    }
}

using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Query;
using Ace.Geograpi.Domain.Abstractions.Query.Pagination;
using Ace.Geograpi.Domain.Abstractions.Query.Params;
using Ace.Geograpi.Domain.Abstractions.Query.Sorting;
using Ace.Geograpi.Domain.Abstractions.Repositories;
using Ace.Geograpi.Domain.Abstractions.Symbols;
using Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;
using AutoMapper.QueryableExtensions;

namespace Ace.Geograpi.Infrastructure.Abstractions.Repositories;

public abstract class AceRepository<TDbContext, TEntity, TModel, TKey, TQueryParams>
    : CrudRepository<TDbContext, TEntity, TModel, TKey>, IAceRepository<TModel, TKey, TQueryParams>
    where TDbContext : DbContext
    where TEntity : class, IEntity<TKey>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
    where TQueryParams : IQueryParams
{
    protected AceRepository(TDbContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    public async Task<QueryResponse<TModel>> GetAsync(QueryRequest<TQueryParams> request, CancellationToken cancellation = default)
    {
        var baseQuery = GetQueriable();

        var filteringQuery = ComposeFilteringQuery(baseQuery, request.QueryParams);
        var count = await filteringQuery.AsNoTracking().CountAsync(cancellation);

        var sortQuery = ComposeSortingQuery(filteringQuery, request);
        var paginationQuery = ApplyPagination(sortQuery, request);

        var items = await paginationQuery
            .AsNoTracking()
            .ProjectTo<TModel>(Mapper.ConfigurationProvider)
            .ToListAsync(cancellation);

        return new QueryResponse<TModel>(request.Page, request.Size, count, items);
    }

    public async Task<int> CountAsync(QueryRequest<TQueryParams> request, CancellationToken cancellation = default)
    {
        var query = GetQueriable();
        query = ComposeFilteringQuery(query, request.QueryParams);

        return await query.AsNoTracking().CountAsync(cancellation);
    }

    protected virtual IQueryable<TEntity> ApplyPagination(IQueryable<TEntity> query, IPaginationRequest request)
    {
        int page = request.Page ?? 1;
        int size = request.Size ?? int.MaxValue;

        return query.Skip((page - 1) * size).Take(size);
    }

    protected virtual IQueryable<TEntity> ComposeSortingQuery(IQueryable<TEntity> query, ISortingRequest request)
    {
        string sortBy = request.SortBy ?? "id";
        var sortDirection = request.SortDirection ?? SortDirection.Ascending;

        if (string.Equals(sortBy, "id", StringComparison.OrdinalIgnoreCase))
        {
            return sortDirection switch
            {
                SortDirection.Descending => query.OrderByDescending(e => e.Id),
                SortDirection.Ascending => query.OrderBy(e => e.Id),
                _ => query
            };
        }

        return query;
    }

    protected abstract IQueryable<TEntity> ComposeFilteringQuery(IQueryable<TEntity> query, TQueryParams queryParams);
}

using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Infrastructure.Data;
using Ace.Geograpi.Infrastructure.Data.Entities;
using CatNip.Domain.ImportExport;
using CatNip.Domain.Query;
using CatNip.Domain.Query.Sorting;
using CatNip.Domain.Query.Sorting.Symbols;
using CatNip.Infrastructure.Repositories;

namespace Ace.Geograpi.Infrastructure.Repositories;

internal sealed class ContinentRepository
    : AceRepository<GeograpiDbContext, ContinentEntity, ContinentModel, int, ContinentQueryFilter, ContinentExchangeDto>, IContinentRepository
{
    public ContinentRepository(GeograpiDbContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    public sealed override async Task<IEnumerable<ContinentModel>> GetAllAsync(
        CancellationToken cancellation = default)
    {
        var continents = await base.GetAllAsync(cancellation);

        return continents;
    }

    public sealed override async Task<IEnumerable<TModelRoot>> GetAllAsync<TModelRoot>(
        CancellationToken cancellation = default)
    {
        var continents = await base.GetAllAsync<TModelRoot>(cancellation);

        return continents;
    }

    public sealed override async Task<int> CountAsync(
        CancellationToken cancellation = default)
    {
        int count = await base.CountAsync(cancellation);

        return count;
    }

    public sealed override async Task<QueryResponse<ContinentModel>> GetAsync(
        QueryRequest<ContinentQueryFilter> request, CancellationToken cancellation = default)
    {
        var result = await base.GetAsync(request, cancellation);

        return result;
    }

    public sealed override async Task<QueryResponse<TModelRoot>> GetAsync<TModelRoot>(
        QueryRequest<ContinentQueryFilter> request, CancellationToken cancellation = default)
    {
        var result = await base.GetAsync<TModelRoot>(request, cancellation);

        return result;
    }

    public sealed override async Task<int> CountAsync(
        ContinentQueryFilter filter, CancellationToken cancellation = default)
    {
        int count = await base.CountAsync(filter, cancellation);

        return count;
    }

    public sealed override async Task<bool> ExistsAsync(
        ContinentQueryFilter filter, CancellationToken cancellation = default)
    {
        bool exists = await base.ExistsAsync(filter, cancellation);

        return exists;
    }

    public sealed override async Task<ContinentModel> GetByIdAsync(
        int id, CancellationToken cancellation = default)
    {
        var continent = await base.GetByIdAsync(id, cancellation);

        return continent;
    }

    public sealed override async Task<bool> ExistsAsync(
        int id, CancellationToken cancellation = default)
    {
        bool exists = await base.ExistsAsync(id, cancellation);

        return exists;
    }

    public sealed override async Task<ContinentModel> CreateAsync(
        ContinentModel model, CancellationToken cancellation = default)
    {
        var continent = await base.CreateAsync(model, cancellation);

        return continent;
    }

    public sealed override async Task UpdateAsync(
        int id, ContinentModel model, CancellationToken cancellation = default)
    {
        await base.UpdateAsync(id, model, cancellation);
    }

    public sealed override async Task DeleteAsync(
        int id, CancellationToken cancellation = default)
    {
        await base.DeleteAsync(id, cancellation);
    }

    public sealed override async Task<ImportResponse> ImportAsync(
        ICollection<ContinentExchangeDto> records, CancellationToken cancellation)
    {
        var continentNames = records.OrderBy(c => c.Name).Select(c => c.Name).ToHashSet(StringComparer.Ordinal);
        var dbContinents = await DbContext
            .Continents
            .AsTracking()
            .Where(c => continentNames.Contains(c.Name))
            .OrderBy(c => c.Name)
            .ToListAsync(cancellation);

        var dbContinentNames = dbContinents.Select(c => c.Name).ToHashSet(StringComparer.Ordinal);
        var continentsToAdd = records.Where(c => !dbContinentNames.Contains(c.Name)).ToList();
        var continentsToUpdate = records.Where(c => dbContinentNames.Contains(c.Name)).ToList();

        foreach (var entryToAdd in continentsToAdd)
        {
            var continent = Mapper.Map<ContinentEntity>(entryToAdd);
            DbContext.Continents.Add(continent);
        }

        foreach (var entryToUpdate in continentsToUpdate)
        {
            var dbEntry = dbContinents.Single(c => string.Equals(entryToUpdate.Name, c.Name, StringComparison.Ordinal));
            Mapper.Map(entryToUpdate, dbEntry);
        }

        await CommitAsync(cancellation);

        return ImportResponse.Success(records.Count, continentsToAdd.Count, continentsToUpdate.Count);
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

    protected sealed override IQueryable<ContinentEntity> BuildDefaultSortingQuery(
        IQueryable<ContinentEntity> query)
    {
        return query.OrderBy(e => e.Name);
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

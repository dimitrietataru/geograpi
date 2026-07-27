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

internal sealed class CountryRepository
    : AceRepository<GeograpiDbContext, CountryEntity, CountryModel, int, CountryQueryFilter, CountryExchangeDto>, ICountryRepository
{
    public CountryRepository(GeograpiDbContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    public sealed override async Task<IEnumerable<CountryModel>> GetAllAsync(
        CancellationToken cancellation = default)
    {
        var countries = await base.GetAllAsync(cancellation);

        return countries;
    }

    public sealed override async Task<IEnumerable<TModelRoot>> GetAllAsync<TModelRoot>(
        CancellationToken cancellation = default)
    {
        var countries = await base.GetAllAsync<TModelRoot>(cancellation);

        return countries;
    }

    public sealed override async Task<int> CountAsync(
        CancellationToken cancellation = default)
    {
        int count = await base.CountAsync(cancellation);

        return count;
    }

    public sealed override async Task<QueryResponse<CountryModel>> GetAsync(
        QueryRequest<CountryQueryFilter> request, CancellationToken cancellation = default)
    {
        var result = await base.GetAsync(request, cancellation);

        return result;
    }

    public sealed override async Task<QueryResponse<TModelRoot>> GetAsync<TModelRoot>(
        QueryRequest<CountryQueryFilter> request, CancellationToken cancellation = default)
    {
        var result = await base.GetAsync<TModelRoot>(request, cancellation);

        return result;
    }

    public sealed override async Task<bool> ExistsAsync(
        CountryQueryFilter filter, CancellationToken cancellation = default)
    {
        bool exists = await base.ExistsAsync(filter, cancellation);

        return exists;
    }

    public sealed override async Task<int> CountAsync(
        CountryQueryFilter filter, CancellationToken cancellation = default)
    {
        int count = await base.CountAsync(cancellation);

        return count;
    }

    public sealed override async Task<CountryModel> GetByIdAsync(
        int id, CancellationToken cancellation = default)
    {
        var country = await base.GetByIdAsync(id, cancellation);

        return country;
    }

    public sealed override async Task<bool> ExistsAsync(
        int id, CancellationToken cancellation = default)
    {
        bool exists = await base.ExistsAsync(id, cancellation);

        return exists;
    }

    public sealed override async Task<CountryModel> CreateAsync(
        CountryModel model, CancellationToken cancellation = default)
    {
        var country = await base.CreateAsync(model, cancellation);

        return country;
    }

    public sealed override async Task UpdateAsync(
        int id, CountryModel model, CancellationToken cancellation = default)
    {
        await base.UpdateAsync(id, model, cancellation);
    }

    public sealed override async Task DeleteAsync(
        int id, CancellationToken cancellation = default)
    {
        await base.DeleteAsync(id, cancellation);
    }

    public sealed override async Task<ImportResponse> ImportAsync(
        ICollection<CountryExchangeDto> records, CancellationToken cancellation)
    {
        var continentNames = records.OrderBy(c => c.ContinentName).Select(c => c.ContinentName).ToHashSet(StringComparer.Ordinal);
        var dbContinentsByName = await DbContext
            .Continents
            .AsNoTracking()
            .Where(c => continentNames.Contains(c.Name))
            .OrderBy(c => c.Name)
            .ToDictionaryAsync(k => k.Name, v => v.Id, cancellation);

        var unknownContinentErrors = records
            .Where(c => !dbContinentsByName.ContainsKey(c.ContinentName))
            .Select(c =>
                new ImportDataIntegrityError
                {
                    RowNumber = c.RowNumber,
                    ErrorMessage = $"Unknown continent '{c.ContinentName}'"
                })
            .ToList();
        if (unknownContinentErrors.Count > 0)
        {
            return ImportResponse.Failure(unknownContinentErrors);
        }

        var countryNames = records.Select(c => c.Name).ToHashSet(StringComparer.Ordinal);
        var dbCountries = await DbContext
            .Counties
            .AsTracking()
            .Where(c => countryNames.Contains(c.Name))
            .OrderBy(c => c.Name)
            .ToListAsync(cancellation);

        var dbCountryNames = dbCountries.Select(c => c.Name).ToHashSet(StringComparer.Ordinal);
        var countriesToAdd = records.Where(c => !dbCountryNames.Contains(c.Name, StringComparer.Ordinal)).ToList();
        var countriestoUpdate = records.Where(c => dbCountryNames.Contains(c.Name, StringComparer.Ordinal)).ToList();

        foreach (var entryToAdd in countriesToAdd)
        {
            var country = Mapper.Map<CountryEntity>(entryToAdd);
            country.ContinentId = dbContinentsByName[entryToAdd.ContinentName];
            DbContext.Counties.Add(country);
        }

        foreach (var entryToUpdate in countriestoUpdate)
        {
            var dbEntry = dbCountries.Single(c => string.Equals(entryToUpdate.Name, c.Name, StringComparison.Ordinal));

            Mapper.Map(entryToUpdate, dbEntry);
            dbEntry.ContinentId = dbContinentsByName[entryToUpdate.ContinentName];
        }

        await CommitAsync(cancellation);

        return ImportResponse.Success(records.Count, countriesToAdd.Count, countriestoUpdate.Count);
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

    protected sealed override IQueryable<CountryEntity> BuildDefaultSortingQuery(
        IQueryable<CountryEntity> query)
    {
        return query.OrderBy(e => e.Name);
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

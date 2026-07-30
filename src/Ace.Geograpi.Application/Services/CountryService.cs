using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Domain.Services;
using CatNip.Application.Services;
using CatNip.Domain.ImportExport;
using CatNip.Domain.ImportExport.Csv;
using CatNip.Domain.ImportExport.Excel;
using CatNip.Domain.Query;

namespace Ace.Geograpi.Application.Services;

public sealed class CountryService
    : AceService<ICountryRepository, CountryModel, int, CountryQueryFilter, CountryExchangeDto>, ICountryService
{
    public CountryService(ICountryRepository repository, ICsvConverter csvConverter, IExcelConverter excelConverter)
        : base(repository, csvConverter, excelConverter)
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

    public sealed override async Task<int> CountAsync(
        CountryQueryFilter filter, CancellationToken cancellation = default)
    {
        int count = await base.CountAsync(filter, cancellation);

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

    public sealed override async Task<ImportResponse> ImportCsvAsync(
        ImportRequest request, CancellationToken cancellation = default)
    {
        return await base.ImportCsvAsync(request, cancellation);
    }

    public sealed override async Task<ImportResponse> ImportExcelAsync(
        ImportRequest request, CancellationToken cancellation = default)
    {
        return await base.ImportExcelAsync(request, cancellation);
    }
}

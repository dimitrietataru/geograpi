using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Domain.Services;
using CatNip.Application.Services;
using CatNip.Domain.Query;

namespace Ace.Geograpi.Application.Services;

internal sealed class ContinentService
    : AceService<IContinentRepository, ContinentModel, int, ContinentQueryFilter>, IContinentService
{
    public ContinentService(IContinentRepository repository)
        : base(repository)
    {
    }

    public sealed override async Task<IEnumerable<ContinentModel>> GetAllAsync(
        CancellationToken cancellation = default)
    {
        var continents = await base.GetAllAsync(cancellation);

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

    public sealed override async Task<int> CountAsync(
        ContinentQueryFilter filter, CancellationToken cancellation = default)
    {
        int count = await base.CountAsync(filter, cancellation);

        return count;
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
}

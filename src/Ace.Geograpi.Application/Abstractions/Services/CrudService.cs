using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Query;
using Ace.Geograpi.Domain.Abstractions.Query.Params;
using Ace.Geograpi.Domain.Abstractions.Repositories;
using Ace.Geograpi.Domain.Abstractions.Services;

namespace Ace.Geograpi.Application.Abstractions.Services;

#pragma warning disable CA1005 // Avoid excessive parameters on generic types
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
public abstract class CrudService<TRepository, TModel, TKey, TQueryParams> : ICrudService<TModel, TKey, TQueryParams>
    where TRepository : ICrudRepository<TModel, TKey>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
    where TQueryParams : IQueryParams
{
    private readonly TRepository repository;

    protected CrudService(TRepository repository)
    {
        this.repository = repository;
    }

    public virtual async Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellation = default)
    {
        var models = await repository.GetAllAsync(cancellation);

        return models;
    }

    public virtual async Task<int> CountAsync(CancellationToken cancellation = default)
    {
        int count = await repository.CountAsync(cancellation);

        return count;
    }

    public virtual Task<QueryResponse<TModel>> GetAsync(QueryRequest<TQueryParams> request, CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<TModel> GetByIdAsync(TKey id, CancellationToken cancellation = default)
    {
        var model = await repository.GetByIdAsync(id, cancellation);

        return model;
    }

    public virtual async Task<TModel> CreateAsync(TModel model, CancellationToken cancellation = default)
    {
        var result = await repository.CreateAsync(model, cancellation);

        return result;
    }

    public virtual async Task UpdateAsync(TModel model, CancellationToken cancellation = default)
    {
        await repository.UpdateAsync(model, cancellation);
    }

    public virtual async Task UpdateAsync(TKey id, TModel model, CancellationToken cancellation = default)
    {
        await repository.UpdateAsync(model, cancellation);
    }

    public virtual async Task DeleteAsync(TModel model, CancellationToken cancellation = default)
    {
        await repository.DeleteAsync(model.Id, cancellation);
    }

    public virtual async Task DeleteAsync(TKey id, CancellationToken cancellation = default)
    {
        await repository.DeleteAsync(id, cancellation);
    }
}

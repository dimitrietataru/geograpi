using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Repositories;
using Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;
using Ace.Geograpi.Infrastructure.Abstractions.Exceptions;

namespace Ace.Geograpi.Infrastructure.Abstractions.Repositories;

#pragma warning disable CA1005 // Avoid excessive parameters on generic types
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
public abstract class CrudRepository<TDbContext, TEntity, TModel, TKey>
    : Repository<TDbContext, TEntity, TKey>, ICrudRepository<TModel, TKey>
    where TDbContext : DbContext
    where TModel : class, IModel<TKey>
    where TEntity : class, IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    private readonly IMapper mapper;

    protected CrudRepository(TDbContext dbContext, IMapper mapper)
        : base(dbContext)
    {
        this.mapper = mapper;
    }

    public virtual async Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellation = default)
    {
        var entities = await GetQueriable()
            .AsNoTracking()
            .ToListAsync(cancellation);

        return mapper.Map<List<TModel>>(entities);
    }

    public virtual async Task<int> CountAsync(CancellationToken cancellation = default)
    {
        int count = await GetQueriable()
            .AsNoTracking()
            .CountAsync(cancellation);

        return count;
    }

    public virtual async Task<TModel> GetByIdAsync(TKey id, CancellationToken cancellation = default)
    {
        var entity = await GetQueriable()
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.Id.Equals(id), cancellation);
        _ = entity ?? throw new EntityNotFoundException<TEntity, TKey>(id);

        return mapper.Map<TModel>(entity);
    }

    public virtual async Task<bool> ExistsAsync(TKey id, CancellationToken cancellation = default)
    {
        bool exists = await GetQueriable()
            .AsNoTracking()
            .AnyAsync(e => e.Id.Equals(id), cancellation);

        return exists;
    }

    public virtual async Task<TModel> CreateAsync(TModel model, CancellationToken cancellation = default)
    {
        var entity = mapper.Map<TEntity>(model);

        await CreateAsync(model, cancellation).ConfigureAwait(false);

        return mapper.Map<TModel>(entity);
    }

    public virtual async Task UpdateAsync(TModel model, CancellationToken cancellation = default)
    {
        var entity = await FindAsync(model.Id);

        await UpdateAsync(entity, cancellation).ConfigureAwait(false);
    }

    public virtual async Task DeleteAsync(TKey id, CancellationToken cancellation = default)
    {
        var entity = await FindAsync(id);

        await DeleteAsync(entity, cancellation).ConfigureAwait(false);
    }
}

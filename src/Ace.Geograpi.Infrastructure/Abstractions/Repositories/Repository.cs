using Ace.Geograpi.Domain.Abstractions.Repositories;
using Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;
using Ace.Geograpi.Infrastructure.Abstractions.Exceptions;

namespace Ace.Geograpi.Infrastructure.Abstractions.Repositories;

#pragma warning disable CA1005 // Avoid excessive parameters on generic types
public abstract class Repository<TDbContext, TEntity, TKey> : Repository<TDbContext, TEntity>
    where TDbContext : DbContext
    where TEntity : class, IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    protected Repository(TDbContext dbContext)
        : base(dbContext)
    {
    }

    public sealed override async Task CommitAsync(CancellationToken cancellation = default)
    {
        _ = await DbContext.SaveChangesAsync(cancellation).ConfigureAwait(false);
    }

    private protected virtual IQueryable<TEntity> GetQueriable()
    {
        return DbContext.Set<TEntity>();
    }

    private protected virtual async Task<TEntity> FindAsync(TKey id)
    {
        var entity = await DbContext.Set<TEntity>().FindAsync(id).ConfigureAwait(false);
        _ = entity ?? throw new EntityNotFoundException<TEntity, TKey>(id);

        return entity!;
    }

    private protected virtual async Task CreateAsync(TEntity entity, CancellationToken cancellation = default)
    {
        Create(entity);
        await CommitAsync(cancellation).ConfigureAwait(false);
    }

    private protected virtual async Task UpdateAsync(TEntity entity, CancellationToken cancellation = default)
    {
        Update(entity);
        await CommitAsync(cancellation).ConfigureAwait(false);
    }

    private protected virtual async Task DeleteAsync(TEntity entity, CancellationToken cancellation = default)
    {
        Delete(entity);
        await CommitAsync(cancellation).ConfigureAwait(false);
    }
}

public abstract class Repository<TDbContext, TEntity> : IRepository<TEntity>
    where TDbContext : DbContext
    where TEntity : class
{
    protected Repository(TDbContext dbContext)
    {
        DbContext = dbContext;
    }

    private protected TDbContext DbContext { get; }

    public virtual void Create(TEntity entity)
    {
        DbContext.Set<TEntity>().Add(entity);
    }

    public virtual void Update(TEntity entity)
    {
        DbContext.Set<TEntity>().Update(entity);
    }

    public virtual void Delete(TEntity entity)
    {
        DbContext.Set<TEntity>().Remove(entity);
    }

    public abstract Task CommitAsync(CancellationToken cancellation = default);
}

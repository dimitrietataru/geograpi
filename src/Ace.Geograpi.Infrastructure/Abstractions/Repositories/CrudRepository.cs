using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Repositories;
using Ace.Geograpi.Infrastructure.Abstractions.Data.Interfaces;
using Ace.Geograpi.Infrastructure.Abstractions.Exceptions;
using AutoMapper.QueryableExtensions;

namespace Ace.Geograpi.Infrastructure.Abstractions.Repositories;

#pragma warning disable CA1005 // Avoid excessive parameters on generic types
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
public abstract class CrudRepository<TDbContext, TEntity, TModel, TKey>
    : Repository<TDbContext, TEntity, TKey>, ICrudRepository<TModel, TKey>
    where TDbContext : DbContext
    where TEntity : class, IEntity<TKey>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
{
    protected CrudRepository(TDbContext dbContext, IMapper mapper)
        : base(dbContext)
    {
        Mapper = mapper;
    }

    protected virtual IMapper Mapper { get; }

    public virtual async Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellation = default)
    {
        var result = await GetQueriable()
            .AsNoTracking()
            .ProjectTo<TModel>(Mapper.ConfigurationProvider)
            .ToListAsync(cancellation);

        return result;
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
        var result = await GetQueriable()
            .AsNoTracking()
            .ProjectTo<TModel>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(e => e.Id.Equals(id), cancellation);
        _ = result ?? throw new EntityNotFoundException<TEntity, TKey>(id);

        return result;
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
        var entity = Mapper.Map<TEntity>(model);

        await CreateAsync(model, cancellation).ConfigureAwait(false);

        return Mapper.Map<TModel>(entity);
    }

    public virtual async Task UpdateAsync(TModel model, CancellationToken cancellation = default)
    {
        var entity = await FindAsync(model.Id);
        Mapper.Map(model, entity);

        await UpdateAsync(entity, cancellation).ConfigureAwait(false);
    }

    public virtual async Task DeleteAsync(TKey id, CancellationToken cancellation = default)
    {
        var entity = await FindAsync(id);

        await DeleteAsync(entity, cancellation).ConfigureAwait(false);
    }
}

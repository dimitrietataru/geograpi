using Ace.Geograpi.Domain.Abstractions.Models.Interfaces;
using Ace.Geograpi.Domain.Abstractions.Query;
using Ace.Geograpi.Domain.Abstractions.Query.Params;
using Ace.Geograpi.Domain.Abstractions.Services;
using Ace.Geograpi.Domain.Abstractions.Symbols;

namespace Ace.Geograpi.Web.Abstractions;

public abstract class CrudController<TService, TModel, TKey, TQueryParams> : ControllerBase
    where TService : ICrudService<TModel, TKey, TQueryParams>
    where TModel : IModel<TKey>
    where TKey : IEquatable<TKey>
    where TQueryParams : IQueryParams
{
    private readonly TService service;

    protected CrudController(TService service)
    {
        this.service = service;
    }

    [HttpGet]
    public virtual async Task<IActionResult> GetAll(CancellationToken cancellation)
    {
        var result = await service.GetAllAsync(cancellation);

        return Ok(result);
    }

    [HttpGet]
    [Route("count")]
    public virtual async Task<IActionResult> Count(CancellationToken cancellation)
    {
        var result = await service.CountAsync(cancellation);

        return Ok(result);
    }

    [HttpGet]
    [Route("{id}")]
    public virtual async Task<IActionResult> GetById([FromRoute] TKey id, CancellationToken cancellation)
    {
        var result = await service.GetByIdAsync(id, cancellation);

        return Ok(result);
    }

    [HttpGet]
    [Route("filter")]
    public virtual async Task<IActionResult> Filter(
        [FromQuery] int? page,
        [FromQuery] int? size,
        [FromQuery] string? sortBy,
        [FromQuery] SortDirection? sortDirection,
        [FromQuery] TQueryParams queryParams,
        CancellationToken cancellation)
    {
        var query = new QueryRequest<TQueryParams>(queryParams, page, size, sortBy, sortDirection);
        var result = await service.GetAsync(query, cancellation);

        return Ok(result);
    }

    [HttpPost]
    public virtual async Task<IActionResult> Create(
        [FromBody] TModel model,
        CancellationToken cancellation)
    {
        var result = await service.CreateAsync(model, cancellation);

        return Created(new Uri($"/{result.Id}", UriKind.Relative), result);
    }

    [HttpPost]
    [Route("{id}")]
    public virtual async Task<IActionResult> Update(
        [FromRoute] TKey id,
        [FromBody] TModel model, CancellationToken cancellation)
    {
        await service.UpdateAsync(id, model, cancellation);

        return NoContent();
    }

    [HttpPost]
    [Route("{id}")]
    public virtual async Task<IActionResult> Delete(
        [FromRoute] TKey id,
        CancellationToken cancellation)
    {
        await service.DeleteAsync(id, cancellation);

        return NoContent();
    }
}

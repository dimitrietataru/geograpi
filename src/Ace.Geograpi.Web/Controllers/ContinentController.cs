using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Services;
using CatNip.Domain.Query;
using CatNip.Domain.Query.Sorting.Symbols;
using CatNip.Presentation.Controllers;
using CatNip.Presentation.Symbols;

namespace Ace.Geograpi.Web.Controllers;

[ApiController]
[Route("api/continents")]
public sealed class ContinentController : AceController<IContinentService, ContinentModel, int, ContinentQueryFilter>
{
    public ContinentController(IContinentService service)
        : base(service)
    {
    }

    [HttpGet]
    [ProducesResponseType<ContinentModel[]>((int)HttpStatusCode.OK)]
    public sealed override async Task<IActionResult> GetAll(CancellationToken cancellation)
    {
        return await base.GetAll(cancellation);
    }

    [HttpGet]
    [Route(DefaultRoutes.Count)]
    [ProducesResponseType<int>((int)HttpStatusCode.OK)]
    public sealed override async Task<IActionResult> Count(CancellationToken cancellation)
    {
        return await base.Count(cancellation);
    }

    [HttpGet]
    [Route(DefaultRoutes.Filter)]
    [ProducesResponseType<QueryResponse<ContinentModel>>((int)HttpStatusCode.OK)]
    public sealed override async Task<IActionResult> Filter(
        [FromQuery] int? page,
        [FromQuery] int? size,
        [FromQuery] string? sortBy,
        [FromQuery] SortDirection? sortDirection,
        [FromQuery] ContinentQueryFilter filter,
        CancellationToken cancellation)
    {
        return await base.Filter(page, size, sortBy, sortDirection, filter, cancellation);
    }

    [HttpGet]
    [Route(DefaultRoutes.FilterCount)]
    [ProducesResponseType<int>((int)HttpStatusCode.OK)]
    public sealed override async Task<IActionResult> FilterCount(
        [FromQuery] ContinentQueryFilter filter, CancellationToken cancellation)
    {
        return await base.FilterCount(filter, cancellation);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType<ContinentModel>((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public sealed override async Task<IActionResult> GetById(
        [FromRoute] int id, CancellationToken cancellation)
    {
        return await base.GetById(id, cancellation);
    }

    [HttpPost]
    [ProducesResponseType<ContinentModel>((int)HttpStatusCode.Created)]
    public sealed override async Task<IActionResult> Create(
        [FromBody] ContinentModel model, CancellationToken cancellation)
    {
        return await base.Create(model, cancellation);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public sealed override async Task<IActionResult> Update(
        [FromRoute] int id, [FromBody] ContinentModel model, CancellationToken cancellation)
    {
        return await base.Update(id, model, cancellation);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public sealed override async Task<IActionResult> Delete(
        [FromRoute] int id, CancellationToken cancellation)
    {
        return await base.Delete(id, cancellation);
    }
}

using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Services;
using CatNip.Domain.Query;
using CatNip.Domain.Query.Sorting.Symbols;
using CatNip.Presentation.Controllers;
using CatNip.Presentation.Symbols;

namespace Ace.Geograpi.Web.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/continents")]
[Produces("application/json")]
public sealed class ContinentController : AceController<IContinentService, ContinentModel, int, ContinentQueryFilter>
{
    public ContinentController(IContinentService service)
        : base(service)
    {
    }

    [HttpGet]
    [ProducesResponseType<QueryResponse<ContinentModel>>((int)HttpStatusCode.OK)]
    public sealed override async Task<IActionResult> GetAll(
        [FromQuery] int? page,
        [FromQuery] int? size,
        [FromQuery] string? sortBy,
        [FromQuery] SortDirection? sortDirection,
        [FromQuery] ContinentQueryFilter filter,
        CancellationToken cancellation)
    {
        return await base.GetAll(page, size, sortBy, sortDirection, filter, cancellation);
    }

    [HttpGet]
    [Route(DefaultRoutes.Count)]
    [ProducesResponseType<int>((int)HttpStatusCode.OK)]
    public sealed override async Task<IActionResult> Count(
        [FromQuery] ContinentQueryFilter filter, CancellationToken cancellation)
    {
        return await base.Count(filter, cancellation);
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

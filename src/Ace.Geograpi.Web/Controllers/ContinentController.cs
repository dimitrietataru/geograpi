using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Services;
using CatNip.Presentation.Controllers;

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
}

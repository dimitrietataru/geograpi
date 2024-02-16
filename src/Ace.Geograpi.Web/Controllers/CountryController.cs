using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Services;
using CatNip.Presentation.Controllers;

namespace Ace.Geograpi.Web.Controllers;

[ApiController]
[Route("api/countries")]
public sealed class CountryController : AceController<ICountryService, CountryModel, int, CountryQueryFilter>
{
    public CountryController(ICountryService service)
        : base(service)
    {
    }

    [HttpGet]
    [ProducesResponseType<CountryModel[]>((int)HttpStatusCode.OK)]
    public sealed override async Task<IActionResult> GetAll(CancellationToken cancellation)
    {
        return await base.GetAll(cancellation);
    }
}

using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.RequestQueries;
using Ace.Geograpi.Domain.Services;
using Ace.Geograpi.Web.Abstractions;

namespace Ace.Geograpi.Web.Controllers;

[ApiController]
public sealed class CountryController : CrudController<ICountryService, Country, int, CountryRequestQuery>
{
    public CountryController(ICountryService service)
        : base(service)
    {
    }

    [HttpGet]
    [ProducesResponseType<Country[]>((int)HttpStatusCode.OK)]
    public sealed override async Task<IActionResult> GetAll(CancellationToken cancellation)
    {
        return await base.GetAll(cancellation);
    }
}

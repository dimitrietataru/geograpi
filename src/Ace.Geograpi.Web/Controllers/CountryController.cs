using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Services;
using CatNip.Presentation.Controllers;

namespace Ace.Geograpi.Web.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/countries")]
[Produces("application/json")]
public sealed class CountryController : AceController<ICountryService, CountryModel, int, CountryQueryFilter>
{
    public CountryController(ICountryService service)
        : base(service)
    {
    }
}

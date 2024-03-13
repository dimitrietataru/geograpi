using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Services;
using Ace.Geograpi.Web.Controllers;
using Ace.Geograpi.Web.Tests.Controllers.Abstractions;

namespace Ace.Geograpi.Web.Tests.Controllers;

public sealed class CountryControllerTests
    : XUnitAceControllerTests<CountryController, ICountryService, CountryModel, int, CountryQueryFilter>
{
    private readonly CountryController countryController;
    private readonly Mock<ICountryService> countryServiceMock;

    public CountryControllerTests()
    {
        countryServiceMock = new Mock<ICountryService>();

        countryController = new CountryController(countryServiceMock.Object);
    }

    protected sealed override CountryController Controller => countryController;
    protected sealed override Mock<ICountryService> ServiceMock => countryServiceMock;
}

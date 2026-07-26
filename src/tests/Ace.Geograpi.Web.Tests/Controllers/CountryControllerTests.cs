using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Services;
using Ace.Geograpi.Web.Controllers;
using CatNip.Presentation.Test.XUnit.Controllers;

namespace Ace.Geograpi.Web.Tests.Controllers;

public sealed class CountryControllerTests
    : AceControllerTests<
        CountryController,
        ICountryService,
        CountryModel,
        CountryRootModel,
        int,
        CountryQueryFilter,
        CountryExchangeDto>
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

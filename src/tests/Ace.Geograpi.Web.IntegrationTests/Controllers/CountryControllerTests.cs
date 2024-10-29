using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Domain.QueryFilters;
using CatNip.Presentation.IntegrationTest.XUnit.Controllers;

namespace Ace.Geograpi.Web.IntegrationTests.Controllers;

public sealed class CountryControllerTests
    : AceControllerIntegrationTests<CountryModel, CountryRootModel, int, CountryQueryFilter>,
    IClassFixture<WebIntegrationTestFactory>
{
    private readonly HttpClient geograpiClient;

    public CountryControllerTests(WebIntegrationTestFactory webAppFactory)
    {
        geograpiClient = webAppFactory.CreateClient();
    }

    protected sealed override HttpClient HttpClient => geograpiClient;
    protected sealed override string Endpoint => "api/v1/countries";
}

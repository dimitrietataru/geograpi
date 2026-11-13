using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Domain.QueryFilters;
using CatNip.Presentation.IntegrationTest.XUnit.Controllers;

namespace Ace.Geograpi.Web.IntegrationTests.Controllers;

public sealed class ContinentControllerTests
    : AceControllerIntegrationTests<ContinentModel, int, ContinentRootModel, ContinentQueryFilter>,
    IClassFixture<WebIntegrationTestFactory>
{
    private readonly HttpClient geograpiClient;

    public ContinentControllerTests(WebIntegrationTestFactory webAppFactory)
    {
        geograpiClient = webAppFactory.CreateClient();
    }

    protected sealed override HttpClient HttpClient => geograpiClient;
    protected sealed override string Endpoint => "api/v1/continents";
}

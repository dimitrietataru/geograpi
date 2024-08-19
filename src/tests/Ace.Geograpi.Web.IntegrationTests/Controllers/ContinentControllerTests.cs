using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Web.IntegrationTests.Abstractions;
using CatNip.Domain.Query;

namespace Ace.Geograpi.Web.IntegrationTests.Controllers;

public sealed class ContinentControllerTests : AbstractWebTest
{
    private readonly HttpClient geograpiClient;

    public ContinentControllerTests(TestWebApplicationFactory webAppFactory)
        : base(webAppFactory)
    {
        geograpiClient = webAppFactory.CreateClient();
    }

    [Fact]
    internal async Task GivenGetAllWhenDataExistsThenReturnsData()
    {
        // Arrange
        var uri = new Uri("api/v1/continents", UriKind.Relative);

        // Act
        var response = await geograpiClient.GetAsync(uri);
        var result = await response.Content.ReadFromJsonAsync<QueryResponse<ContinentRootModel>>();

        // Assert
        result.Should().NotBeNull();
        result!.Items.Should().NotBeNullOrEmpty().And.AllBeAssignableTo<ContinentRootModel>();
    }
}

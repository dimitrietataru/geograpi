using Ace.Geograpi.Domain.Models.Root;
using CatNip.Domain.Query;

namespace Ace.Geograpi.Web.IntegrationTests.Controllers;

public sealed class ContinentControllerTests : IClassFixture<TestWebApplicationFactory>
{
    private readonly HttpClient geograpiClient;

    public ContinentControllerTests(TestWebApplicationFactory webAppFactory)
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

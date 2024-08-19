namespace Ace.Geograpi.Web.IntegrationTests.Abstractions;

public abstract class AbstractWebTest : IClassFixture<TestWebApplicationFactory>
{
    private readonly IServiceScope scope;

    protected AbstractWebTest(TestWebApplicationFactory webAppFactory)
    {
        scope = webAppFactory.Services.CreateScope();
    }

    protected IServiceScope Scope => scope;
}

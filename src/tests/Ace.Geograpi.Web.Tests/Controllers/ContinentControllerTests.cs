using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Services;
using Ace.Geograpi.Web.Controllers;
using Ace.Geograpi.Web.Tests.Controllers.Abstractions;

namespace Ace.Geograpi.Web.Tests.Controllers;

public sealed class ContinentControllerTests
    : XUnitAceControllerTests<ContinentController, IContinentService, ContinentModel, int, ContinentQueryFilter>
{
    private readonly ContinentController continentController;
    private readonly Mock<IContinentService> continentServiceMock;

    public ContinentControllerTests()
    {
        continentServiceMock = new Mock<IContinentService>();

        continentController = new ContinentController(continentServiceMock.Object);
    }

    protected sealed override ContinentController Controller => continentController;
    protected sealed override Mock<IContinentService> ServiceMock => continentServiceMock;
}

using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Services;
using Ace.Geograpi.Web.Controllers;
using CatNip.Presentation.Test.XUnit.Controllers;

namespace Ace.Geograpi.Web.Tests.Controllers;

public sealed class ContinentControllerTests
    : AceControllerTests<
        ContinentController,
        IContinentService,
        ContinentModel,
        ContinentRootModel,
        int,
        ContinentQueryFilter,
        ContinentExchangeDto>
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

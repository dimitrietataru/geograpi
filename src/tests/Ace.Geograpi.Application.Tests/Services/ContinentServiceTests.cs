using Ace.Geograpi.Application.Services;
using Ace.Geograpi.Application.Tests.Services.Abstractions;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;

namespace Ace.Geograpi.Application.Tests.Services;

public sealed class ContinentServiceTests : XUnitAceServiceTests<ContinentService, IContinentRepository, ContinentModel, int, ContinentQueryFilter>
{
    private readonly ContinentService continentService;
    private readonly Mock<IContinentRepository> continentRepositoryMock;

    public ContinentServiceTests()
    {
        continentRepositoryMock = new Mock<IContinentRepository>();

        continentService = new ContinentService(continentRepositoryMock.Object);
    }

    protected sealed override ContinentService Service => continentService;
    protected sealed override Mock<IContinentRepository> RepositoryMock => continentRepositoryMock;
}

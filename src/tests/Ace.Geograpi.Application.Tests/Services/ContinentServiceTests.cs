using Ace.Geograpi.Application.Services;
using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using CatNip.Application.Test.XUnit.Services;
using CatNip.Domain.ImportExport.Csv;

namespace Ace.Geograpi.Application.Tests.Services;

public sealed class ContinentServiceTests
    : AceServiceTests<
        ContinentService,
        IContinentRepository,
        ContinentModel,
        ContinentRootModel,
        int,
        ContinentQueryFilter,
        ContinentExchangeDto>
{
    private readonly ContinentService continentService;
    private readonly Mock<IContinentRepository> continentRepositoryMock;
    private readonly Mock<ICsvConverter> csvConverter;

    public ContinentServiceTests()
    {
        continentRepositoryMock = new Mock<IContinentRepository>();
        csvConverter = new Mock<ICsvConverter>();

        continentService = new ContinentService(continentRepositoryMock.Object, csvConverter.Object);
    }

    protected sealed override ContinentService Service => continentService;
    protected sealed override Mock<IContinentRepository> RepositoryMock => continentRepositoryMock;
    protected sealed override Mock<ICsvConverter> CsvConverterMock => csvConverter;
}

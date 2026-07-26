using Ace.Geograpi.Application.Services;
using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using CatNip.Application.Test.XUnit.Services;
using CatNip.Domain.ImportExport.Csv;

namespace Ace.Geograpi.Application.Tests.Services;

public sealed class CountryServiceTests
    : AceServiceTests<
        CountryService,
        ICountryRepository,
        CountryModel,
        CountryRootModel,
        int,
        CountryQueryFilter,
        CountryExchangeDto>
{
    private readonly CountryService countryService;
    private readonly Mock<ICountryRepository> countryRepositoryMock;
    private readonly Mock<ICsvConverter> csvConverter;

    public CountryServiceTests()
    {
        countryRepositoryMock = new Mock<ICountryRepository>();
        csvConverter = new Mock<ICsvConverter>();

        countryService = new CountryService(countryRepositoryMock.Object, csvConverter.Object);
    }

    protected sealed override CountryService Service => countryService;
    protected sealed override Mock<ICountryRepository> RepositoryMock => countryRepositoryMock;
    protected sealed override Mock<ICsvConverter> CsvConverterMock => csvConverter;
}

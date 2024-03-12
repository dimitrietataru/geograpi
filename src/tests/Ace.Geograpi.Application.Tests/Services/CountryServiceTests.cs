using Ace.Geograpi.Application.Services;
using Ace.Geograpi.Application.Tests.Services.Abstractions;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;

namespace Ace.Geograpi.Application.Tests.Services;

public sealed class CountryServiceTests : XUnitAceServiceTests<CountryService, ICountryRepository, CountryModel, int, CountryQueryFilter>
{
    private readonly CountryService countryService;
    private readonly Mock<ICountryRepository> countryRepositoryMock;

    public CountryServiceTests()
    {
        countryRepositoryMock = new Mock<ICountryRepository>();

        countryService = new CountryService(countryRepositoryMock.Object);
    }

    protected sealed override CountryService Service => countryService;
    protected sealed override Mock<ICountryRepository> RepositoryMock => countryRepositoryMock;
}

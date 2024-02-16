using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.QueryFilters;
using Ace.Geograpi.Domain.Repositories;
using Ace.Geograpi.Domain.Services;
using CatNip.Application.Services;

namespace Ace.Geograpi.Application.Services;

internal sealed class CountryService
    : AceService<ICountryRepository, CountryModel, int, CountryQueryFilter>, ICountryService
{
    public CountryService(ICountryRepository repository)
        : base(repository)
    {
    }
}

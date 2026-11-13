using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Domain.Models;
using Ace.Geograpi.Domain.Models.Root;
using Ace.Geograpi.Domain.QueryFilters;
using CatNip.Domain.Services;

namespace Ace.Geograpi.Domain.Services;

public interface ICountryService : IAceService<CountryModel, int, CountryRootModel, CountryQueryFilter, CountryExchangeDto>
{
}

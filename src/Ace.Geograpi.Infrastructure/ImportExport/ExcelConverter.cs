using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Infrastructure.ImportExport.Mappings;
using CatNip.Infrastructure.ImportExport;
using CatNip.Infrastructure.ImportExport.Mappings;

namespace Ace.Geograpi.Infrastructure.ImportExport;

public sealed class ExcelConverter : AceExcelConverter
{
    private readonly IReadOnlyDictionary<Type, IExcelMap> mappings;

    public ExcelConverter()
    {
        mappings = new Dictionary<Type, IExcelMap>
        {
            [typeof(ContinentExchangeDto)] = ContinentExchangeExcelMap.Instance,
            [typeof(CountryExchangeDto)] = CountryExchangeExcelMap.Instance,
        };
    }

    protected sealed override IReadOnlyDictionary<Type, IExcelMap> Mappings => mappings;
}

using Ace.Geograpi.Domain.ImportExport.Dtos;
using Ace.Geograpi.Infrastructure.ImportExport.Mappings;
using CatNip.Infrastructure.ImportExport;
using CsvHelper.Configuration;

namespace Ace.Geograpi.Infrastructure.ImportExport;

internal sealed class CsvConverter : AceCsvConverter
{
    private readonly IReadOnlyDictionary<Type, Type> mappings;
    private readonly CsvConfiguration configuration;

    public CsvConverter()
    {
        mappings = new Dictionary<Type, Type>
        {
            [typeof(ContinentExchangeDto)] = typeof(ContinentExchangeCsvMap),
            [typeof(CountryExchangeDto)] = typeof(CountryExchangeCsvMap)
        };

        configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",",
            HasHeaderRecord = true,
            IgnoreBlankLines = true,
            TrimOptions = TrimOptions.Trim,
            DetectDelimiter = false
        };
    }

    protected sealed override IReadOnlyDictionary<Type, Type> Mappings => mappings;

    protected override CsvConfiguration Configuration => configuration;
}

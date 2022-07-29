using Runtime.Resolver.Interfaces;
using Runtime.Resolver.Models;

namespace Runtime.Resolver.Services;

public class AddressLookupsService
{
    private readonly Dictionary<Country, ICountryAddressLookupsRepository> _countryToRepository;
    private readonly RepositoryResolver _resolver;
    public AddressLookupsService(Dictionary<Country, ICountryAddressLookupsRepository> countryToRepository, RepositoryResolver resolver)
    {
        _countryToRepository = countryToRepository;
        _resolver = resolver;
    }

    public List<AddressLookupsEntity> GetLookups(string isoCountry)
    {
        var iso = Enum.Parse<Country>(isoCountry, true);
        
        // var repository = _countryToRepository[iso];
        var repository = _resolver(iso);
        
        return repository.GetAddressLookups(string.Empty);
    }
}
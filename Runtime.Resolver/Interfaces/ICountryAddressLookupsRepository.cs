using Runtime.Resolver.Models;

namespace Runtime.Resolver.Interfaces;

public interface ICountryAddressLookupsRepository
{
    List<AddressLookupsEntity> GetAddressLookups(string componentCode);
}
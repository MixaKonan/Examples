using Runtime.Resolver.Interfaces;
using Runtime.Resolver.Models;

namespace Runtime.Resolver.Repositories;

public class BritainAddressLookupsRepository : IBritainAddressLookupsRepository
{
    public List<AddressLookupsEntity> GetAddressLookups(string componentCode)
    {
        return new List<AddressLookupsEntity>()
        {
            new BritainAddressLookups()
            {
                City = "London",
                State = "Greater London City of London",
                PostCode = "E1 6AN"
            }
        };
    }
}
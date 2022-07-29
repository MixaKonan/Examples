using Runtime.Resolver.Interfaces;
using Runtime.Resolver.Models;

namespace Runtime.Resolver.Repositories;

public class CanadaAddressLookupsRepository : ICanadaAddressLookupsRepository
{
    public List<AddressLookupsEntity> GetAddressLookups(string componentCode)
    {
        return new List<AddressLookupsEntity>()
        {
            new CanadaAddressLookups()
            {
                City = "Toronto",
                State = "Ontario",
                PostCode = "M4C"
            }
        };
    }
}
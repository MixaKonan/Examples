using Runtime.Resolver.Interfaces;
using Runtime.Resolver.Models;

namespace Runtime.Resolver.Repositories;

public class AustraliaAddressLookupsRepository : IAustraliaAddressLookupsRepository
{
    public List<AddressLookupsEntity> GetAddressLookups(string componentCode)
    {
        return new List<AddressLookupsEntity>()
        {
            new AustraliaAddressLookups()
            {
                City = "Canberra",
                State = "Australian Capital Territory",
                PostCode = "2601"
            }
        };
    }
}
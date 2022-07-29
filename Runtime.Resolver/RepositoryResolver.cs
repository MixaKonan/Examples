using Runtime.Resolver.Interfaces;
using Runtime.Resolver.Models;

namespace Runtime.Resolver;

public delegate ICountryAddressLookupsRepository RepositoryResolver(Country country);
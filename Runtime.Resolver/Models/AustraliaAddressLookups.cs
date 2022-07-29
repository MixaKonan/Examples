using System.ComponentModel.DataAnnotations.Schema;

namespace Runtime.Resolver.Models;

[Table("AddressLookupsAU")]
public class AustraliaAddressLookups : AddressLookupsEntity
{
    public override string IsoCountry => "AU";
}
using System.ComponentModel.DataAnnotations.Schema;

namespace Runtime.Resolver.Models;

[Table("AddressLookupsGB")]
public class BritainAddressLookups : AddressLookupsEntity
{
    public override string IsoCountry => "GB";
}
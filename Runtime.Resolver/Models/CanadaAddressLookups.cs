using System.ComponentModel.DataAnnotations.Schema;

namespace Runtime.Resolver.Models;

[Table("AddressLookupsCA")]
public class CanadaAddressLookups : AddressLookupsEntity
{
    public override string IsoCountry => "CA";
}
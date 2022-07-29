using System.ComponentModel.DataAnnotations.Schema;

namespace Runtime.Resolver.Models;

public class AddressLookupsEntity
{
    [NotMapped]
    public virtual string IsoCountry { get; }

    public string City { get; set; }
    
    public string State { get; set; }
    
    public string PostCode { get; set; }
}
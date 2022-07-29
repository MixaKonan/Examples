using Microsoft.AspNetCore.Mvc;
using Runtime.Resolver.Services;

namespace Runtime.Resolver.Controllers;

[ApiController]
public class AddressLookupController : ControllerBase
{
    private readonly AddressLookupsService _addressLookupsService;

    public AddressLookupController(AddressLookupsService addressLookupsService)
    {
        _addressLookupsService = addressLookupsService;
    }

    [HttpPost("lookup/get")]
    public IActionResult GetLookup([FromBody] string isoCountry)
    {
        var result = _addressLookupsService.GetLookups(isoCountry);
        
        return Ok(result);
    }
}
using Runtime.Resolver;
using Runtime.Resolver.Interfaces;
using Runtime.Resolver.Models;
using Runtime.Resolver.Repositories;
using Runtime.Resolver.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IAustraliaAddressLookupsRepository, AustraliaAddressLookupsRepository>();
builder.Services.AddTransient<ICanadaAddressLookupsRepository, CanadaAddressLookupsRepository>();
builder.Services.AddTransient<IBritainAddressLookupsRepository, BritainAddressLookupsRepository>();

builder.Services.AddTransient<AddressLookupsService>();

builder.Services.AddTransient<Dictionary<Country, ICountryAddressLookupsRepository>>(
    services => new()
    {
        { Country.Australia, services.GetService<IAustraliaAddressLookupsRepository>() ?? throw new InvalidOperationException() },
        { Country.Canada, services.GetService<ICanadaAddressLookupsRepository>() ?? throw new InvalidOperationException() },
        { Country.GreatBritain, services.GetService<IBritainAddressLookupsRepository>() ?? throw new InvalidOperationException() },
    });

builder.Services.AddTransient<RepositoryResolver>(services => country =>
{
    return country switch
    {
        Country.Australia => services.GetService<IAustraliaAddressLookupsRepository>() ?? throw new InvalidOperationException(),
        Country.Canada => services.GetService<ICanadaAddressLookupsRepository>() ?? throw new InvalidOperationException(),
        Country.GreatBritain => services.GetService<IBritainAddressLookupsRepository>() ?? throw new InvalidOperationException(),
        _ => throw new ArgumentOutOfRangeException(nameof(country), country, null)
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
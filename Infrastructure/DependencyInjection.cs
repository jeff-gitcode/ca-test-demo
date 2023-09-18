using Application.Abstractions;
using Domain;
using Infrastructure.Weather;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IRepository<WeatherForecast>, WeatherRepository>();
        return services;
    }
}

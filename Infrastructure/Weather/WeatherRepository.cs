using Application.Abstractions;
using Application.Weather.Queries;
using Domain;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Weather
{
    public class WeatherRepository : IRepository<WeatherForecast>
    {
        private static readonly string[] Summaries = new[]{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly ILogger<GetWeatherForecastQueryHandler> _logger;
        private DateOnly dateTime;
        public WeatherRepository(ILogger<GetWeatherForecastQueryHandler> logger)
        {
            _logger = logger;
        }


        public async Task<IEnumerable<WeatherForecast>> GetAll(bool noTracking = true)
        {
            _logger.LogInformation("Infrastructure.Weather");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = dateTime.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();

        }
    }
}

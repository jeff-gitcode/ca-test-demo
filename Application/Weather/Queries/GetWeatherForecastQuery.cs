using Application.Abstractions;
using Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Weather.Queries
{
    public sealed record GetWeatherForecastQuery : IRequest<IEnumerable<WeatherForecast>>
    {
        public DateOnly DateTime { get; set; }
    }

    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, IEnumerable<WeatherForecast>>
    {
        private ILogger<GetWeatherForecastQueryHandler> _logger;
        private IRepository<WeatherForecast> _weatherRepository;
        public GetWeatherForecastQueryHandler(ILogger<GetWeatherForecastQueryHandler> logger, IRepository<WeatherForecast> weatherRepository)
        {
            _logger = logger;
            _weatherRepository = weatherRepository;
        }
        public async Task<IEnumerable<WeatherForecast>> Handle(GetWeatherForecastQuery query, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Application.Weather.Queries");

            return await _weatherRepository.GetAll();
        }
    }
}
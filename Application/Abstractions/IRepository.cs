using Domain;

namespace Application.Abstractions
{
    public interface IRepository<T> where T : class, new()
    {
        Task<IEnumerable<WeatherForecast>> GetAll(bool noTracking = true);
    }
}

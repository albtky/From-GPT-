using Features.Weather;

namespace Application.Weather
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<WeatherForecast>> GetAllAsync();
        Task AddAsync(WeatherForecast forecast);
    }
}

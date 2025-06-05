using System.Collections.Generic;
using System.Threading.Tasks;
using Features.Weather;

namespace Application.Weather
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<WeatherForecast>> GetForecastAsync();
    }
}

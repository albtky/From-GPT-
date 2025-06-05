using MediatR;

namespace Features.Weather
{
    // Query definition for retrieving weather forecasts. Returns a collection
    // of data transfer objects that will be mapped from domain entities.
    public class GetWeatherForecast : IRequest<IEnumerable<WeatherDto>>
    {
    }
}

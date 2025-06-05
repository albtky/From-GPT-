using MediatR;

namespace Features.Weather
{
    public class GetWeatherForecast : IRequest<IEnumerable<WeatherForecast>>
    {
    }
}

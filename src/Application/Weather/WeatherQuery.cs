using Features.Weather;
using MediatR;

namespace Application.Weather
{
    public record WeatherQuery() : IRequest<IEnumerable<WeatherForecast>>;
}

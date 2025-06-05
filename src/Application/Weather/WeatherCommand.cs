using MediatR;

namespace Application.Weather
{
    public record WeatherCommand(DateTime Date, int TemperatureC, string Summary) : IRequest;
}

using MediatR;

namespace Features.Weather
{
    public class CreateWeather
    {
        public record Command(string Date, int TemperatureC, string Summary) : IRequest<WeatherForecast>;

        public class Handler : IRequestHandler<Command, WeatherForecast>
        {
            public Task<WeatherForecast> Handle(Command request, CancellationToken cancellationToken)
            {
                var parsedDate = DateTime.Parse(request.Date);
                var forecast = new WeatherForecast
                {
                    Date = parsedDate,
                    TemperatureC = request.TemperatureC,
                    Summary = request.Summary
                };

                return Task.FromResult(forecast);
            }
        }
    }
}

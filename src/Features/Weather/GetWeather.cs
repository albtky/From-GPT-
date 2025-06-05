using MediatR;

namespace Features.Weather
{
    public class GetWeather
    {
        public record Query(DateTime Date) : IRequest<WeatherForecast>;

        public class Handler : IRequestHandler<Query, WeatherForecast>
        {
            public Task<WeatherForecast> Handle(Query request, CancellationToken cancellationToken)
            {
                var forecast = new WeatherForecast
                {
                    Date = request.Date,
                    TemperatureC = 25,
                    Summary = "Sample"
                };

                return Task.FromResult(forecast);
            }
        }
    }
}

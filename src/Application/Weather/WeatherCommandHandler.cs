using MediatR;
using Features.Weather;

namespace Application.Weather
{
    public class WeatherCommandHandler : IRequestHandler<WeatherCommand>
    {
        private readonly IWeatherRepository _repository;

        public WeatherCommandHandler(IWeatherRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(WeatherCommand request, CancellationToken cancellationToken)
        {
            var forecast = new WeatherForecast
            {
                Date = request.Date,
                TemperatureC = request.TemperatureC,
                Summary = request.Summary
            };

            await _repository.AddAsync(forecast);
            return Unit.Value;
        }
    }
}

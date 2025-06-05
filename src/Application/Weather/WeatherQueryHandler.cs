using MediatR;
using Features.Weather;

namespace Application.Weather
{
    public class WeatherQueryHandler : IRequestHandler<WeatherQuery, IEnumerable<WeatherForecast>>
    {
        private readonly IWeatherRepository _repository;

        public WeatherQueryHandler(IWeatherRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<WeatherForecast>> Handle(WeatherQuery request, CancellationToken cancellationToken)
        {
            return _repository.GetAllAsync();
        }
    }
}

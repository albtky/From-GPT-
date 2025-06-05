using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Features.Weather;

namespace Application.Weather
{
    public class GetWeatherForecastHandler : IRequestHandler<GetWeatherForecast, IEnumerable<WeatherDto>>
    {
        private readonly IWeatherRepository _repository;
        private readonly IMapper _mapper;

        public GetWeatherForecastHandler(IWeatherRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WeatherDto>> Handle(GetWeatherForecast request, CancellationToken cancellationToken)
        {
            var forecasts = await _repository.GetForecastAsync();
            return _mapper.Map<IEnumerable<WeatherDto>>(forecasts);
        }
    }
}

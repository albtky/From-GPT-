using AutoMapper;

namespace Features.Weather
{
    public class WeatherMappingProfile : Profile
    {
        public WeatherMappingProfile()
        {
            CreateMap<WeatherForecast, WeatherDto>().ReverseMap();
        }
    }
}

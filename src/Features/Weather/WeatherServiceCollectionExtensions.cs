using System.Collections.Generic;
using Application.Weather;
using Infrastructure.Weather;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Features.Weather
{
    public static class WeatherServiceCollectionExtensions
    {
        public static IServiceCollection AddWeatherFeatureServices(this IServiceCollection services)
        {
            // Register repository and handler dependencies for the weather feature
            services.AddSingleton<IWeatherRepository, InMemoryWeatherRepository>();
            services.AddTransient<IRequestHandler<GetWeatherForecast, IEnumerable<WeatherDto>>, Application.Weather.GetWeatherForecastHandler>();

            // Register AutoMapper profile for this feature
            services.AddAutoMapper(typeof(WeatherMappingProfile));
            return services;
        }
    }
}

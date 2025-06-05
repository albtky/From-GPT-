using System.Threading;
using System.Threading.Tasks;
using Application.Weather;
using AutoMapper;
using Features.Weather;
using Infrastructure.Weather;
using Xunit;

namespace Application.Tests
{
    public class WeatherQueryHandlerTests
    {
        [Fact]
        public async Task Handle_ReturnsForecasts()
        {
            var repo = new InMemoryWeatherRepository();
            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<WeatherMappingProfile>());
            var mapper = mapperConfig.CreateMapper();
            var handler = new GetWeatherForecastHandler(repo, mapper);

            var result = await handler.Handle(new GetWeatherForecast(), CancellationToken.None);

            Assert.NotEmpty(result);
        }
    }
}

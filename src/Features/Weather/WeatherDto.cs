using System;

namespace Features.Weather
{
    public class WeatherDto
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }
}

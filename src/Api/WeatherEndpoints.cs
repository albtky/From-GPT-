using Features.Weather;

namespace Api;

public static class WeatherEndpoints
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public static void MapWeatherEndpoints(this WebApplication app)
    {
        app.MapGet("/weather", GetWeather);
        app.MapPost("/weather", PostWeather);
    }

    private static IResult GetWeather()
    {
        var rng = new Random();
        var forecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        });

        return Results.Json(ApiResponse.Ok(forecast));
    }

    private static IResult PostWeather(WeatherForecast forecast)
    {
        // Echo back the forecast or store it somewhere in a real app
        return Results.Json(ApiResponse.Ok(forecast));
    }
}

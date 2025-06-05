using Features.Weather;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Register logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register feature services
builder.Services.AddMediatR(typeof(Features.Weather.GetWeatherForecast));
builder.Services.AddWeatherFeatureServices();

var app = builder.Build();

// Configure middleware
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/weather", async (IMediator mediator, ILoggerFactory loggerFactory) =>
{
    var logger = loggerFactory.CreateLogger("Weather");
    logger.LogInformation("Fetching weather forecasts");
    var result = await mediator.Send(new GetWeatherForecast());
    return Results.Ok(result);
});

app.Run();

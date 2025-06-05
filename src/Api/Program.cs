using Api;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseMiddleware<GlobalExceptionMiddleware>();

app.MapWeatherEndpoints();

app.Run();

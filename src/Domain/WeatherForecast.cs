using System;

namespace Domain;

public record WeatherForecast(Guid Id, DateTime Date, Temperature Temperature, City City, string? Summary) : Entity(Id);

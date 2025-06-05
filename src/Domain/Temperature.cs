namespace Domain;

public record Temperature(double Celsius) : ValueObject
{
    public double Fahrenheit => Celsius * 9 / 5 + 32;
}

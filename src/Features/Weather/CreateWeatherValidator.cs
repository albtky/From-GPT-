using FluentValidation;

namespace Features.Weather
{
    public class CreateWeatherValidator : AbstractValidator<CreateWeather.Command>
    {
        public CreateWeatherValidator()
        {
            RuleFor(x => x.TemperatureC)
                .InclusiveBetween(-50, 60);

            RuleFor(x => x.Date)
                .NotEmpty()
                .Must(date => DateTime.TryParse(date, out _))
                .WithMessage("Date must be in a valid format");

            RuleFor(x => x.Summary)
                .NotEmpty();
        }
    }
}

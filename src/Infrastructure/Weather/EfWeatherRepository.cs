using Application.Weather;
using Features.Weather;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Weather
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options) { }

        public DbSet<WeatherForecast> Forecasts { get; set; }
    }

    public class EfWeatherRepository : IWeatherRepository
    {
        private readonly WeatherDbContext _context;

        public EfWeatherRepository(WeatherDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WeatherForecast>> GetAllAsync()
        {
            return await _context.Forecasts.ToListAsync();
        }

        public async Task AddAsync(WeatherForecast forecast)
        {
            _context.Forecasts.Add(forecast);
            await _context.SaveChangesAsync();
        }
    }
}

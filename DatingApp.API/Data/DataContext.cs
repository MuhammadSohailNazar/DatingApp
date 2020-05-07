
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<WeatherForecastModel> WeatherForecasts { get; set; }
        public DbSet<TestModel> TestModels { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
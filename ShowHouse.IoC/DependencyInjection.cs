using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShowHouse.Data.Context;
using ShowHouse.Data.Context.Repositories;
using ShowHouse.Domain.Interfaces;

namespace ShowHouse.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddScoped<IShowHouseEventRepository, ShowHouseRepository>();
            services.AddScoped<IEventRepository, EventRepository>();

            return services; 
        }
    }
}
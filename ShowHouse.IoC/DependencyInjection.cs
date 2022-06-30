using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShowHouse.Application.Interfaces;
using ShowHouse.Application.Mapping;
using ShowHouse.Application.Services;
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
            services.AddScoped<IStyleRepository, StyleRepository>();

            services.AddScoped<IShowHouseEventService, ShowHouseEventService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IStyleService, StyleService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services; 
        }
    }
}
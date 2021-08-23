using API.Data;
using API.Helpers;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly); //In order to use automapper in the project
            services.AddScoped<IUserRepository, UserRepository>(); //This will make use of the newly introduced repository pattern
            services.AddDbContext<DataContext>(options => //For setting up the connection string for our application
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection")); //Adding connection string from appsettings.Development.json
            });
            services.AddScoped<ITokenService, TokenService>(); // For dependency injection of the implemented services and interfaces

            return services;
        }
    }
}

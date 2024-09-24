using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBody.Application.Services.Contracts;
using MyBody.Application.Services.Services;
using MyBody.infra.Data;
using MyBody.infra.Data.Repositories;


namespace MyBody.Infra.Data.IoC
{
    public static class DependencyContainer
    {
        public static void AddWebApiConfigurations(this IServiceCollection services, IConfiguration config)
        {
            // Services
            services.AddScoped<IUserService, UserService>();

            // Repos

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<DbContext, ApplicationDbContext>();



            // Database Config
            services.AddMyBodyDataBase(config);
        }

        public static IServiceCollection AddMyBodyDataBase(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUnitOfWork, UnitOdWork>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = config.GetConnectionString("MyBodyCS");
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("MyBody.Services.WebApi").MigrationsHistoryTable("__EFMigrationsHistory_Data"));
            });
            var environmente = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return services;
        }
    }
}

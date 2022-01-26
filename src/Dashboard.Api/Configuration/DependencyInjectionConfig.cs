using Dashboard.Business.Interfaces;
using Dashboard.Business.Interfaces.Repository;
using Dashboard.Business.Notifications;
using Dashboard.Data.Context;
using Dashboard.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Dashboard.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<INotificator, Notificator>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}

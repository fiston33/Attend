using Microsoft.Extensions.DependencyInjection;
using Application.Services.StudentServices;

namespace Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
             services.AddScoped<IStudentService, StudentService>();
            return services;
        }
    }
}
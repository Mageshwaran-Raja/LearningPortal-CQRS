using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Kanini.LearningPortal.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());   
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}

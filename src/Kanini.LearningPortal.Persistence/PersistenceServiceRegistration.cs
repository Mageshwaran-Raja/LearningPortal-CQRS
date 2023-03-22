using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Persistence.DatabaseContext;
using Kanini.LearningPortal.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kanini.LearningPortal.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LearningPortalDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DatabaseConnectionString")));

            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IRolesRepository, RolesRepository>();
            services.AddScoped<IDepartmentsRepository, DepartmentsRepository>();

            return services;
        }
    }
}

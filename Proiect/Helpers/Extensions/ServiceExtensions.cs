using Demo.Services.CourseService;
using Proiect.Helpers.Jwt;
using Proiect.Helpers.Seeders;
using Proiect.Repositories.DatabaseRepository;
using Proiect.Repositories.EmployeeRepository;
using Proiect.Repositories.EmployeeStoreRepository;
using Proiect.Repositories.OwnerRepository;
using Proiect.Repositories.StoreRepository;
using Proiect.Services;

namespace Proiect.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IOwnerRepository, OwnerRepository>();
            services.AddTransient<IStoreRepository, StoreRepository>();
            services.AddTransient<IEmployeeStoreRepository, EmployeeStoreRepository>();
            services.AddTransient<IDatabaseRepository, DatabaseRepository>();

      return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IStoreService, StoreService>();

      return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<EmployeesSeeder>();
      return services;
        }

        public static IServiceCollection AddUtils(this IServiceCollection services)
        {
            services.AddTransient<IJwtUtils, JwtUtils>();
      return services;
        }
    }
}

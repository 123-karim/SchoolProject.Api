using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            //configuration pf mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //configuration pf Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }
    }
}

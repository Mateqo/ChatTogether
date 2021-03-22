using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ChatTogether.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            //Dodawanie serwisu

            //Przykład:
            //services.AddTransient<IUserService, UserService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;

namespace ChatTogether.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //Dodawanie repozytoriów

            //Przykład:
            //services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}

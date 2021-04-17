using Microsoft.Extensions.DependencyInjection;

namespace SevenSem.Auth.Impl.Ioc
{
    public static class Module
    {
        public static IServiceCollection WithAuthModule(this IServiceCollection services)
        {
            return services.AddSingleton<IJwtTokenFactory, JwtTokenFactory>();
        }
    }
}
using Drugovich.Domain.Interfaces.Services;
using Drugovich.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Drugovich.Service.DI
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IClienteService, ClienteService>();
            serviceCollection.AddTransient<IGerenteService, GerenteService>();
            serviceCollection.AddTransient<IGrupoService, GrupoService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<ITokenService, TokenService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}

using Integracao.IOC.Modulos;
using Microsoft.Extensions.DependencyInjection;

namespace Integracao.IOC
{
    public class IntegracaoBootstrapper
    {
        public static void RegisterServices(IServiceCollection container)
        {
            RepositoryModule.SetModules(container);
            ServiceModule.SetModules(container);
        }
    }
}

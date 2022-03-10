using IBBA.Services;
using IBBA.Services.Interfaces;
using maxiPago.Services.Interfaces;
using maxiPago.Services.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace Integracao.IOC.Modulos
{
    public class ServiceModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<IPixApiService, PixApiService>();
            container.AddScoped<ITransaction, Transaction>();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using NETCoreHelloWorldWebApi.Services.Concrete;
using NETCoreHelloWorldWebApi.Services.Interfaces;

namespace NETCoreHelloWorldWebApi.Infrastructure.Container
{
    internal static class ServicesModule
    {
        internal static void Configure(IServiceCollection container)
        {
            container.AddScoped<IMessageManager, MessageManager>();
        }
    }
}
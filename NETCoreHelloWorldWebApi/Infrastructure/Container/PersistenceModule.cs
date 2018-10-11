using Microsoft.Extensions.DependencyInjection;
using NETCoreHelloWorldWebApi.Persistence.Store.Authors;
using NETCoreHelloWorldWebApi.Persistence.Store.Messages;

namespace NETCoreHelloWorldWebApi.Infrastructure.Container
{
    internal static class PersistenceModule
    {
        internal static void Configure(IServiceCollection container)
        {
            container.AddScoped<IAuthorRepository, AuthorRepository>();
            container.AddScoped<IMessageRepository, MessageRepository>();
        }
    }
}
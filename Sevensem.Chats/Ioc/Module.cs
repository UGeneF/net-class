using Microsoft.Extensions.DependencyInjection;
using Sevensem.Chats.Abstract;
using Sevensem.Chats.Infra;
using Sevensem.Chats.Infra.Ef;
using Sevensem.Chats.Service;

namespace Sevensem.Chats.Ioc
{
    public static class Module
    {
        public static IServiceCollection WithChatsModule(this IServiceCollection services, string connString)
        {
            services.AddSingleton<IMessagesService, MessagesService>();
            services.AddSingleton<IMessagesRepository, MessagesRepository>();
            services.AddSingleton<IContextFactory>(new ContextFactory(connString));
            return services;
        }
    }
}
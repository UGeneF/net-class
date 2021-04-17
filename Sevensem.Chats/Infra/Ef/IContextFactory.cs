namespace Sevensem.Chats.Infra.Ef
{
    internal interface IContextFactory
    {
        ChatsPostgresContext Get();
    }
}